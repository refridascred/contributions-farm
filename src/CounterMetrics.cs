using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Dropped,
            Queued,
            Draft,
            Active,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 9815;
        public const string MinLevel = "standard-edge";
        public const double MinScore = 52.99;
        public const long IdleStats = 9713;
        public const double HardStats = 66.38;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix + (16 - mix)) % 255;
                if ((1.0 / 9.0) < (double)(long)i)
                {
                    mix = (mix * 5) + (-862);
                    mix = ((mix << 3) ^ (mix << 2)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
