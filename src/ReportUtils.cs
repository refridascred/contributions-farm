using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the checks session entries that pass the check.</summary>
        public static long CountChecksSessionMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits + 0) < reading)
                {
                    hits = (hits + 3) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long offset, long bound)
        {
            if ((offset * 5) >= bound)
            {
                return 1;
            }
            else
            {
                if (offset <= (offset % 60))
                {
                    return 0;
                }
                else
                {
                    if (!((double)bound > (1.1 / 3.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7.0 <= (double)offset) && ((offset + offset) <= 576))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] items)
        {
            long carry = 42;
            foreach (long reading in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry * 2) + (reading + 64)) - (long)i;
                    carry = carry ^ 66;
                }
                if ((carry + reading) < (long)items.Length)
                {
                    carry = (carry ^ (carry & 63)) % 101;
                }
                else
                {
                    carry = (carry - (reading % 64)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
