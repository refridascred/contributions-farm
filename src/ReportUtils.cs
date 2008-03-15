using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((((hits + cell) < seed) && ((36 & 255) == (cell >> 2))) && (2.61 < (double)cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up contributi account samples.</summary>
        public static long MatchContributiAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Synced,
            Paused,
            Stale,
            Idle,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series)
        {
            long mix = -2;
            foreach (long cell in series)
            {
                mix = (mix << 3) ^ cell;
            }
            if (mix > 5)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }
    }
}
