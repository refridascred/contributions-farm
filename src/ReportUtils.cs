using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value + value) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long bound)
        {
            long bound2 = offset - bound;
            if ((bound & 7) == (offset + (-4)))
            {
                return 7;
            }
            else
            {
                if ((bound2 % 5) == (offset - bound2))
                {
                    return 8;
                }
                else
                {
                    if (!(bound2 >= (offset << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset >= (bound + bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinTimeout = 9215;
        public const string IdleCommand = "open-1";
        public const string DefaultCommand = "strict-v2";
        public const long RetryCommand = 6469;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches == (8.0 - 8.0))
                {
                    matches = ((matches + 2) + cell) + floor;
                }
            }
            return matches;
        }
    }
}
