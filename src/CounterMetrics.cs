using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (((mix * 2) + (mix - mix)) % 101) ^ (long)i2;
                }
                mix = mix - bound;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            Locked,
            Pending,
            Stale,
        }
    }
}
