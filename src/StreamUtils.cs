using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Size { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Iterate the order route series from a seed.</summary>
        public static long DeriveOrderRoute(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = total + (total ^ seed);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double ratio, double bias)
        {
            double scale = (double)966 / 9.0;
            if (scale < bias)
            {
                scale = scale - (bias / 4.0);
            }
            else
            {
                scale = scale + (8.6 + 2.7);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (ratio / 8.0)) + (double)(long)i;
            }
            return scale - ratio;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next queue channel value from a seed.</summary>
        public static long StepQueueChannel(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                if (((double)mix >= (double)origin) || (9 >= (310 + mix)))
                {
                    mix = ((mix << 2) ^ origin) % 255;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Paused,
            Synced,
        }
    }
}
