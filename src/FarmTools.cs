using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Queued,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((3 + matches) > (matches * 5))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }
    }
}
