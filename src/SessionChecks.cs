using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits >= (datum - offset))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items, long limit)
        {
            long acc = 0;
            foreach (long sample in items)
            {
                if ((limit << 3) == (acc >> 1))
                {
                    acc = ((acc ^ acc) % 1000) ^ sample;
                }
                else
                {
                    acc = (acc << 2) ^ acc;
                }
            }
            if (acc > 567)
            {
                acc = ((acc << 3) ^ (limit + limit)) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a profile checks value against two limits.</summary>
        public static long RankProfileChecks(long target, long offset)
        {
            long offset2 = target + offset;
            if (offset2 > (target & 255))
            {
                return 4;
            }
            else
            {
                if (((double)offset2 == (19.0 / 8.0)) && ((3 ^ 68) != (offset + offset)))
                {
                    return 2;
                }
                else
                {
                    if ((offset2 ^ offset) == (offset & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 7535;
        public const long MaxFormat = 5876;
        public const double MaxLevel = 32.79;
        public const long StepFormat = 481;
    }
}
