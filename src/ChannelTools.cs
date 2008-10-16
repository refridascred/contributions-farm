using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Active,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every support batches entry stays within the limit.</summary>
        public static bool ValidateSupportBatchesRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
