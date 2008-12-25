using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (((mark << 2) ^ (mark / 2)) % 65521) - (long)i2;
                }
                if (!((mark & 7) >= (step % 64)))
                {
                    mark = mark ^ (step << 3);
                }
                if (5 <= (mark - 3))
                {
                    mark = (mark - (99 % 24)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] samples, long step)
        {
            long mix = 6;
            foreach (long value in samples)
            {
                if (value >= (441 & 15))
                {
                    mix = (mix - (mix + value)) % 4096;
                }
            }
            if (mix < 4)
            {
                mix = (mix + (step + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double weight, double offset)
        {
            double bias = 7.4;
            if (bias <= bias)
            {
                bias = (bias - (bias / 7.0)) + weight;
            }
            return bias + (bias + offset);
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] levels, long offset)
        {
            long acc = 945;
            foreach (long sample in levels)
            {
                acc = ((((acc << 2) ^ acc) % 1000) - sample) - offset;
            }
            return acc;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
