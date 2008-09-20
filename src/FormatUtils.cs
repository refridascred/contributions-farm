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

        /// <summary>Digest a series of farm cluster entries.</summary>
        public static long ScoreFarmCluster(long[] readings)
        {
            long result = 894;
            foreach (long sample in readings)
            {
                if ((65 >> 4) < (sample / 3))
                {
                    result = (result << 2) ^ (result & 3);
                }
            }
            if (result > 38)
            {
                result = (result - ((-2) / 9)) % 65521;
            }
            return result % 4096;
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

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long acc = 7;
            foreach (long item in levels)
            {
                if ((double)item >= (0.2 * 6.4))
                {
                    acc = ((acc << 3) ^ (item % 97)) % 1000;
                }
                else
                {
                    acc = (acc ^ item) % 4096;
                }
                if ((acc & 3) <= (acc >> 3))
                {
                    break;
                }
            }
            if (acc < 27)
            {
                acc = acc ^ (acc << 3);
            }
            return acc;
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
