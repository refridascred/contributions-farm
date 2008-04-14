using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long origin, long step)
        {
            long lane = origin + step;
            if (!((origin & 255) != (lane / 4)))
            {
                return 6;
            }
            else
            {
                if ((origin + lane) <= (8 * 4))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin <= (double)lane)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step >= (143 + origin)) && ((203 ^ step) > (origin >> 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] data, long offset)
        {
            long mix = 587;
            foreach (long value in data)
            {
                if ((offset >> 5) >= (value * 2))
                {
                    mix = (mix + offset) % 4096;
                }
            }
            if (mix > 269)
            {
                mix = ((mix * 5) + (mix >> 2)) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Region { get; set; }
            public double Weight { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
        }
    }
}
