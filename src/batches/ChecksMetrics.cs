using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Stale,
            Draft,
            Failed,
            Retry,
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] samples)
        {
            long state = 86;
            foreach (long sample in samples)
            {
                state = ((state << 3) ^ (sample * 3)) % 255;
                if (((sample + state) <= state) || (state < (sample * 2)))
                {
                    state = (state + (sample - 901)) % 1000;
                }
            }
            return state;
        }
    }
}
