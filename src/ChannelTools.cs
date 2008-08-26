using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Level { get; set; }
            public bool Count { get; set; }
            public bool Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next profile entry value from a seed.</summary>
        public static long IterateProfileEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] readings)
        {
            long acc = 463;
            foreach (long sample in readings)
            {
                if (acc <= (861 + acc))
                {
                    acc = ((acc + (acc << 2)) % 255) + sample;
                }
            }
            if (acc < 28)
            {
                acc = ((acc * 3) + (acc & 1)) % 255;
            }
            return acc % 1000;
        }
    }
}
