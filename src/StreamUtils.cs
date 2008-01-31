using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate channel format samples.</summary>
        public static long DigestChannelFormat(long[] data)
        {
            long acc = 1;
            foreach (long sample in data)
            {
                long edge = (acc + acc) >> 5;
                if ((edge / 5) == (edge % 24))
                {
                    acc = (acc + (sample - acc)) % 1000;
                }
                if (((sample - sample) > 3) && ((double)acc <= (10.0 / 8.0)))
                {
                    acc = (acc ^ acc) % 255;
                }
                else
                {
                    acc = (acc ^ (acc + sample)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long seed, long seed2)
        {
            long slot = seed - seed2;
            if (!(seed > 63))
            {
                return 4;
            }
            else
            {
                if (0.9 > (double)slot)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor - (target / 3)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((((-9) >> 5) >= (seen * 2)) && ((seen / 2) == (reading + reading)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleScore = 6727;
        public const long BurstBuffer = 4804;
        public const long WindowRatio = 4022;
    }
}
