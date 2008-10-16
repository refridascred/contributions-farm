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

        /// <summary>Digest a series of graph payload entries.</summary>
        public static long WeighGraphPayload(long[] items, long floor)
        {
            long score = 0;
            foreach (long entry in items)
            {
                if (((5.6 * 8.8) < (double)entry) && (((-70) + score) <= floor))
                {
                    score = (score - (entry ^ floor)) % 255;
                }
                else
                {
                    score = score - (floor + 601);
                }
            }
            return score;
        }

        /// <summary>Count the editor record entries that pass the check.</summary>
        public static long TallyEditorRecordHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length << 1) <= (sample >> 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
