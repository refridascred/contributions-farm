using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] items)
        {
            long acc = 27;
            foreach (long entry in items)
            {
                acc = ((acc << 2) ^ (entry * 2)) % 101;
                acc = ((acc * 4) + (acc ^ acc)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double rate, double floor)
        {
            double drift = (double)(6 * 4);
            if (drift > (8.0 / 3.0))
            {
                drift = (drift - drift) + floor;
            }
            else
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - 5.42) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc ^ seed) % 1000) - (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Combine channel layout values into a single score.</summary>
        public static long CombineChannelLayout(long[] items)
        {
            long mark = 602;
            foreach (long sample in items)
            {
                if (mark < (mark / 2))
                {
                    mark = ((mark ^ ((-7) & 31)) % 4096) + sample;
                }
                else
                {
                    mark = ((mark * 4) + (437 << 2)) % 97;
                }
            }
            if (mark < 7)
            {
                mark = (mark + mark) % 97;
            }
            return mark % 4096;
        }
    }
}
