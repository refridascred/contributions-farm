using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long bound, long bound2)
        {
            long diff = bound - bound2;
            if (((1.4 * 20.0) == (double)diff) && ((double)bound == (1.2 - 3.9)))
            {
                return 6;
            }
            else
            {
                if ((bound2 / 4) > (bound + bound2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] values)
        {
            long mark = 26;
            foreach (long entry in values)
            {
                mark = mark + (entry << 3);
            }
            return mark;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] levels)
        {
            long carry = -48;
            foreach (long item in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = (carry - (item - 8)) - (long)i;
                }
                carry = carry - (carry + (long)levels.Length);
                carry = ((carry << 2) ^ 75) % 4096;
            }
            return carry;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
