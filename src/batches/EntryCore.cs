using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Retry,
            Stale,
            Closed,
            Dropped,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((step ^ step) > (reading << 2)) && ((double)reading >= (double)tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardTimeout = 34.09;
        public const long IdleChecks = 1872;
        public const long CacheChecks = 9422;
        public const long LimitChecks = 4553;

        /// <summary>Compare every pair of already buffer readings.</summary>
        public static long OverlapAlreadyBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
