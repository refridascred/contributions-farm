using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples)
        {
            long mix = 71;
            foreach (long item in samples)
            {
                mix = (mix ^ (item + item)) % 97;
            }
            return mix;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many queue batch samples are out of range.</summary>
        public static long CountQueueBatchOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((15.0 * 5.6) < (4.07 + 5.2))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many route checks samples are out of range.</summary>
        public static long CountRouteChecksOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((double)tally > 3.86))
                {
                    tally = ((tally + 2) - value) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSession = 70.92;
        public const double SoftFactor = 25.11;
        public const long BaseSession = 3303;
        public const double MinSpan = 29.56;

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long bound, long seed)
        {
            long span = bound + seed;
            if (span >= seed)
            {
                return 1;
            }
            else
            {
                if (!(9 >= (3 ^ span)))
                {
                    return 3;
                }
                else
                {
                    if ((9.6 + 6.0) < (double)span)
                    {
                        return 4;
                    }
                    else
                    {
                        if (span >= (bound % 7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
