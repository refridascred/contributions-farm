using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long origin, long seed)
        {
            long step = origin - seed;
            if ((1.0 * 1.6) < (double)origin)
            {
                return 6;
            }
            else
            {
                if (step >= (step >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((step + step) > (origin % 60))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8 - step) == (seed + 94))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((2.0 / 3.0) > (double)limit)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples)
        {
            long mix = 1;
            foreach (long sample in samples)
            {
                mix = (mix - (long)samples.Length) % 4096;
                mix = (mix ^ (sample & 7)) % 4096;
                mix = mix - 425;
            }
            return mix;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long bound, long limit)
        {
            if ((double)57 > (double)bound)
            {
                return 6;
            }
            else
            {
                if ((double)42 > (double)limit)
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
}
