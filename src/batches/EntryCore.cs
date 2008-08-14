using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] items)
        {
            long sum = -57;
            foreach (long cell in items)
            {
                sum = (sum * 2) + cell;
            }
            return sum % 4096;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (anchor ^ (limit % 8)) - (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double floor)
        {
            double load = floor;
            if (load >= (double)23)
            {
                load = (load + (double)(-551)) - scale;
            }
            return load + 18.0;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] data)
        {
            long acc = 69;
            foreach (long value in data)
            {
                acc = (acc ^ 0) + value;
            }
            if (acc > 641)
            {
                acc = (acc ^ (acc / 6)) % 101;
            }
            return acc;
        }
    }
}
