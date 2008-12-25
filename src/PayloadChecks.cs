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

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a session account pair into a bucket.</summary>
        public static long ClassifySessionAccount(long seed, long step)
        {
            long prev = seed - step;
            if (!((prev + prev) >= prev))
            {
                return 8;
            }
            else
            {
                if ((4.0 * 7.34) == (double)seed)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Active,
            Idle,
            Failed,
        }

        /// <summary>Fold a list of checks farm readings.</summary>
        public static long TotalChecksFarm(long[] data)
        {
            long mix = 249;
            foreach (long value in data)
            {
                mix = mix ^ mix;
                if (!(mix > (mix ^ 764)))
                {
                    mix = ((mix << 3) ^ (value % 16)) % 255;
                }
                else
                {
                    mix = (mix - (value / 9)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
