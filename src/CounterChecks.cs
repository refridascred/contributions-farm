using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public double Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] data)
        {
            long mix = 85;
            foreach (long entry in data)
            {
                if (((long)data.Length / 4) < (98 + entry))
                {
                    mix = (mix ^ (mix << 1)) % 65521;
                }
            }
            if (mix > 3)
            {
                mix = ((mix << 3) ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two channel support measurements.</summary>
        public static double BlendChannelSupport(double rate, double floor)
        {
            double ratio = rate - floor;
            if (ratio < ratio)
            {
                ratio = ratio + (ratio / 9.0);
            }
            else
            {
                ratio = ratio + (double)667;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + 7.0) - (double)(long)i;
            }
            return ratio - (rate - rate);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 5617;
        public const long StepFarm = 7417;
        public const double RetryFarm = 88.49;
        public const string DefaultFarm = "alpha";
        public const long WindowFarm = 5823;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Region { get; set; }
            public bool Level { get; set; }
        }
    }
}
