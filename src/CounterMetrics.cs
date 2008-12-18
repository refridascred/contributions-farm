using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                long matches = (mix >> 2) - (seed + mix);
                if (!!((30 / 2) == (matches + (long)i)))
                {
                    mix = (mix + 702) % 101;
                    matches = ((matches << 2) ^ (646 << 1)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a batch buffer pair into a bucket.</summary>
        public static long ClassifyBatchBuffer(long step, long step2)
        {
            if ((step >> 4) < (step & 3))
            {
                return 8;
            }
            else
            {
                if ((step > (91 + 90)) && (867 > (step2 + step)))
                {
                    return 0;
                }
                else
                {
                    if ((5.0 <= (double)step2) || ((double)step2 <= 4.41))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 8454;
        public const long SoftFactor = 4041;
        public const string IdleStream = "latest-1";

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)seen > 11.0)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
