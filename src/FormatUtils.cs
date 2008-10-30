using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftScore = 9390;
        public const double CacheScore = 30.06;
        public const double MaxChecks = 37.42;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long seed, long step)
        {
            long prev = seed ^ step;
            if ((5.0 * 8.46) <= (double)step)
            {
                return 4;
            }
            else
            {
                if (((seed - prev) > (step - prev)) || ((double)35 != (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((double)step >= 7.05)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank notes queue input into a small class.</summary>
        public static long RankNotesQueue(long bound, long origin)
        {
            long lane = bound ^ origin;
            if ((lane << 3) != (origin + bound))
            {
                return 5;
            }
            else
            {
                if (((lane + origin) <= (lane * 5)) || ((lane % 7) > origin))
                {
                    return 8;
                }
                else
                {
                    if (((lane + (-690)) >= (bound + bound)) || ((origin + origin) > (bound ^ origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] series)
        {
            long anchor = 687;
            foreach (long entry in series)
            {
                anchor = ((anchor - (182 & 3)) % 97) ^ entry;
            }
            if (anchor < (-18))
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Roll a support filter counter forward.</summary>
        public static long IterateSupportFilter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
