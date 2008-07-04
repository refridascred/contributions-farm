using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Done,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Match up queue window samples.</summary>
        public static long MatchQueueWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxWidth = 5313;
        public const string DefaultBuffer = "local-v2";
        public const long HardBuffer = 7585;
        public const double MaxDepth = 55.4;

        /// <summary>Count layout record pairs that satisfy a relation.</summary>
        public static long OverlapLayoutRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long target, long offset)
        {
            long bound = target + offset;
            if ((offset >> 1) < (bound + 0))
            {
                return 1;
            }
            else
            {
                if (3 < (bound >> 4))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
