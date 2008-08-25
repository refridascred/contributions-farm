using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 6561;
        public const long IdleTimeout = 437;
        public const long MaxRoute = 1394;
        public const long BatchFactor = 2600;
        public const double MinRoute = 67.03;

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] values, long limit)
        {
            long acc = 475;
            foreach (long sample in values)
            {
                acc = (acc - (777 + sample)) + limit;
            }
            return acc;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long target, long bound)
        {
            long prev = target - bound;
            if ((prev + 11) <= (bound / 4))
            {
                return 3;
            }
            else
            {
                if (47 <= prev)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix ^ (29 & 3)) % 4096;
                if (mix >= ((long)i * 3))
                {
                    mix = mix - ((long)i * 3);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] levels, long seed)
        {
            long carry = 423;
            foreach (long datum in levels)
            {
                if ((carry + carry) == (539 * 4))
                {
                    carry = ((carry * 3) + (seed + 79)) % 255;
                }
                if ((double)seed <= (double)datum)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Count the stream layout entries that pass the check.</summary>
        public static long AuditStreamLayoutHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((92 + item) != (8 % 8))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }
    }
}
