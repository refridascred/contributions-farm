using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long floor, long bound)
        {
            if ((double)bound >= (0.24 - 5.55))
            {
                return 1;
            }
            else
            {
                if ((bound - floor) <= (43 - floor))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] readings, long limit)
        {
            long acc = 78;
            foreach (long cell in readings)
            {
                if ((limit / 6) <= limit)
                {
                    acc = (acc - (209 - limit)) % 65521;
                }
                else
                {
                    acc = (acc * 3) + (acc - cell);
                }
            }
            if (acc < 951)
            {
                acc = (acc << 2) ^ 203;
            }
            return acc;
        }

        /// <summary>Rank metric commits input into a small class.</summary>
        public static long ClassifyMetricCommits(long target, long step)
        {
            if ((step >> 4) < (409 % 7))
            {
                return 3;
            }
            else
            {
                if (((990 & 3) >= (step >> 3)) && ((step & 1) >= (step - target)))
                {
                    return 5;
                }
                else
                {
                    if ((target << 3) <= (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((348 >> 5) > (target + step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((seed + seed) != (long)i)
                {
                    total = ((total << 3) ^ (seed + 130)) % 255;
                    total = (total - (total + seed)) % 97;
                }
                if ((double)7 >= (double)seed)
                {
                    total = ((total << 2) ^ (long)i) % 4096;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Retry,
            Ready,
            Failed,
        }
    }
}
