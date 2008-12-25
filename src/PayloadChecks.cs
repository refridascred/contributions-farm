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
