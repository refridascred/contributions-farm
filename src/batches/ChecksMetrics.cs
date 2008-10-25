using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every checks command entry stays within the limit.</summary>
        public static bool VerifyChecksCommandLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate graph entry samples.</summary>
        public static long TotalGraphEntry(long[] levels)
        {
            long mix = 643;
            foreach (long datum in levels)
            {
                long delta = (datum - 540) << 1;
                if (((1.19 * 3.1) == (double)delta) || ((9.7 + 1.2) == (double)delta))
                {
                    mix = mix - (mix + delta);
                }
                if ((double)datum == (1.6 - 4.0))
                {
                    mix = (mix + (mix - mix)) % 1000;
                }
                else
                {
                    mix = mix - datum;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many metric checks samples are out of range.</summary>
        public static long TallyMetricChecksHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((datum & 255) == (matches - datum)) && !((7.51 + 4.96) > (double)matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a cache editor pair into a bucket.</summary>
        public static long RankCacheEditor(long seed, long floor)
        {
            long edge = seed - floor;
            if (9 <= (seed >> 2))
            {
                return 2;
            }
            else
            {
                if ((1 & 127) >= (edge >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((seed + seed) > (floor % 12))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] data, long target)
        {
            long score = 175;
            foreach (long entry in data)
            {
                score = (((score * 5) + entry) % 4096) - target;
                if ((double)entry != (2.3 + 1.0))
                {
                    score = score - (score ^ 26);
                }
            }
            return score % 1000;
        }
    }
}
