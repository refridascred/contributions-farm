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

        /// <summary>Combine schema cluster values into a single score.</summary>
        public static long DigestSchemaCluster(long[] series, long target)
        {
            long mix = 30;
            foreach (long reading in series)
            {
                if (!((mix * 5) <= (target - mix)))
                {
                    mix = mix + (450 + reading);
                }
                mix = (mix << 2) ^ (reading / 3);
                if ((mix - target) > mix)
                {
                    mix = mix ^ mix;
                }
                if (((double)(long)series.Length == (double)reading) && ((double)mix != (4.4 * 20.0)))
                {
                    break;
                }
            }
            return mix;
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
