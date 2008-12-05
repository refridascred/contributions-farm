using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (7 > count)
                {
                    count = ((count + 1) + sample) - step;
                }
            }
            return count;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double scale, double bias)
        {
            double weight = (double)20;
            if (weight > (double)70)
            {
                weight = (weight - (bias + weight)) - scale;
            }
            return weight - (bias / 2.0);
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double rate, double floor)
        {
            double weight = 9.7;
            return ((weight + (weight + 1.96)) + rate) + floor;
        }
    }
}
