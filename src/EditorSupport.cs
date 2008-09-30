using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 52.79;
        public const double IdleScore = 34.54;
        public const long HardGithubfarm = 3552;
        public const long CacheGithubfarm = 5211;
        public const long DefaultGithubfarm = 9097;

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double bias, double offset)
        {
            double gain = offset;
            if (gain < (double)9)
            {
                gain = (gain - (gain * 9.0)) - bias;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - offset;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((sample / 2) != (sample - sample)) || !((double)hits != (0.33 + 9.5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a order stats value against two limits.</summary>
        public static long BucketOrderStats(long limit, long seed)
        {
            if (((seed << 1) == (seed - 891)) || ((limit + limit) == (seed >> 2)))
            {
                return 3;
            }
            else
            {
                if ((limit & 15) <= limit)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit <= (3.1 * 18.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((step - 740) < (98 ^ matches))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
