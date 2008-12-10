using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Fold a list of account layout readings.</summary>
        public static long TotalAccountLayout(long[] values, long bound)
        {
            long total = 287;
            foreach (long cell in values)
            {
                if ((cell + 392) > cell)
                {
                    total = (total - ((long)values.Length >> 4)) - bound;
                }
            }
            return total;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Stale,
            Ready,
            Active,
            Synced,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
