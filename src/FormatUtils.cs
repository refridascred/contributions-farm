using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((9.18 / 7.0) <= (double)tally)
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double scale, double offset)
        {
            double load = offset;
            if (load <= load)
            {
                load = (load - (load + load)) + scale;
            }
            return load - (double)713;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] data)
        {
            long score = 673;
            foreach (long entry in data)
            {
                if (!((score % 100) != (0 * 4)))
                {
                    score = (score - score) % 255;
                }
                if ((9.7 * 9.46) >= (double)entry)
                {
                    score = score ^ (entry >> 3);
                }
                else
                {
                    score = score - (581 & 15);
                }
            }
            if (score < 47)
            {
                score = ((score * 2) + (score << 2)) % 1000;
            }
            return score;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Pending,
            Paused,
        }
    }
}
