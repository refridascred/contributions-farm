using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Level { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next channel order value.</summary>
        public static double ScaleChannelOrder(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 < offset)
            {
                weight2 = weight2 + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + weight) - (double)(long)i;
            }
            return weight2 - (offset * 5.8);
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 3) + (acc + acc)) % 255;
                acc = ((acc << 2) ^ (acc % 16)) % 255;
                acc = (acc ^ 623) % 4096;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
