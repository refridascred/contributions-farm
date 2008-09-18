using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)sample <= (double)hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Paused,
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long bound, long step)
        {
            long bound2 = bound ^ step;
            if ((bound2 + 6) != (step >> 3))
            {
                return 7;
            }
            else
            {
                if (((double)bound2 >= (4.2 * 7.2)) && ((7 >> 1) < (bound ^ bound)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the profile buffer series from a seed.</summary>
        public static long IterateProfileBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = (score << 2) ^ ((long)i * 4);
                if (!((double)limit > 12.0))
                {
                    score = ((score << 3) ^ (score * 3)) % 1000;
                    score = score ^ ((long)i + score);
                }
                if ((score ^ score) < (limit >> 5))
                {
                    score = ((score << 2) ^ 4) % 255;
                    score = ((score * 5) + ((long)i << 1)) % 255;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
