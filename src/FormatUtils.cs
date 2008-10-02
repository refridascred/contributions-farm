using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate profile route samples.</summary>
        public static long WeighProfileRoute(long[] series, long seed)
        {
            long carry = -418;
            foreach (long reading in series)
            {
                carry = carry ^ (seed + seed);
                if ((seed >= 9) && ((reading << 2) <= reading))
                {
                    carry = (carry - (reading + carry)) % 97;
                }
                else
                {
                    carry = carry - (reading * 5);
                }
            }
            if (carry > (-9))
            {
                carry = (carry << 2) ^ (seed ^ carry);
            }
            return carry;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i + (long)i) <= (71 << 1))
                {
                    state = ((state * 2) + state) % 101;
                }
                else
                {
                    state = (state * 2) + ((long)i % 8);
                }
                if (!(((double)origin > 6.31) || ((state - state) > state)))
                {
                    state = ((state << 2) ^ origin) % 255;
                }
                state = (state + state) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] samples, long origin)
        {
            long mark = 61;
            foreach (long cell in samples)
            {
                mark = (mark * 5) + mark;
                if ((cell - cell) >= (22 - origin))
                {
                    mark = mark ^ (mark >> 3);
                }
                if ((665 / 6) >= cell)
                {
                    break;
                }
            }
            if (mark < 40)
            {
                mark = (mark + (origin * 3)) % 255;
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "strict-v2";
        public const double CacheSpan = 75.12;
        public const long MaxWidth = 8316;
        public const long WindowWidth = 8179;
        public const string StepCounter = "fallback-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseScore = 912;
        public const string BatchBatches = "fallback";
        public const long BurstWidth = 2789;
        public const long DefaultScore = 4746;
        public const long CacheBatches = 5111;
    }
}
