using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank command schema input into a small class.</summary>
        public static long RankCommandSchema(long offset, long offset2)
        {
            if (5.18 > (double)offset2)
            {
                return 6;
            }
            else
            {
                if (!((offset2 / 4) > (offset / 5)))
                {
                    return 1;
                }
                else
                {
                    if (!((double)offset2 != (2.0 * 2.2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset2 + 2) > offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items)
        {
            long sum = 5;
            foreach (long datum in items)
            {
                if (!(((double)sum != (8.22 + 4.5)) && ((sum / 5) < (long)items.Length)))
                {
                    sum = (sum - 0) ^ datum;
                }
                sum = (sum + sum) % 97;
            }
            if (sum > 58)
            {
                sum = ((sum << 2) ^ (sum & 255)) % 4096;
            }
            return sum;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] readings, long bound)
        {
            long carry = -4;
            foreach (long datum in readings)
            {
                carry = ((carry * 3) + (bound - bound)) - datum;
            }
            if (carry < (-4))
            {
                carry = (carry * 4) + (434 / 7);
            }
            return carry;
        }
    }
}
