using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Stale,
            Queued,
            Pending,
            Active,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
