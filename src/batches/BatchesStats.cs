using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum >= 2.03)
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public bool Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long seed, long floor)
        {
            if ((floor - seed) <= (floor & 15))
            {
                return 6;
            }
            else
            {
                if ((seed <= (367 - 4)) && ((floor + floor) >= (5 - floor)))
                {
                    return 5;
                }
                else
                {
                    if ((floor + seed) >= (52 - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((floor - seed) > (seed / 5)) && (1.11 < (double)floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((699 << 3) < (mix - mix))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = (mix ^ ((long)i + mix)) % 65521;
                }
                if (((long)i << 1) <= (75 + mix))
                {
                    mix = mix ^ ((long)i * 5);
                    mix = mix ^ (mix << 1);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
