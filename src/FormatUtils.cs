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

        /// <summary>Fold a list of editor context readings.</summary>
        public static long CombineEditorContext(long[] items, long floor)
        {
            long state = 24;
            foreach (long item in items)
            {
                state = ((state * 3) + item) % 101;
                if ((13.0 - 7.0) > (double)floor)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double gain = (double)354;
            if (gain >= offset)
            {
                gain = gain - scale;
            }
            else
            {
                gain = gain - (offset / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - offset) - (double)(long)i;
            }
            return gain + scale;
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

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(((9.7 - 5.6) == (double)hits) || ((hits + hits) <= (491 - cell))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
