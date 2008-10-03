using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double bias, double span)
        {
            double ratio = (double)(16 + 77);
            if (ratio > 6.9)
            {
                ratio = ((ratio + (double)84) - bias) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)666) - (double)(long)i;
            }
            return ratio + (double)9;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "cached-edge";
        public const long BatchSchema = 949;
        public const long BaseTimeout = 3781;
        public const long RetryScore = 170;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Queued,
            Synced,
            Stale,
            New,
            Paused,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
