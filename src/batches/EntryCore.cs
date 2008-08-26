using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 1296;
        public const string IdleContext = "strict-1";
        public const long BatchCount = 9037;
        public const double MinContext = 63.9;
        public const string WindowCount = "strict-edge";

        /// <summary>Find the first token contributi entry that matches the target.</summary>
        public static long SeekTokenContributiIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a session notes figure with a bias.</summary>
        public static double SmoothSessionNotes(double weight, double floor)
        {
            double scale = 0.7;
            return ((scale + 2.0) + weight) + floor;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] data, long limit)
        {
            long sum = 647;
            foreach (long entry in data)
            {
                sum = (sum + (limit + limit)) ^ entry;
                sum = sum - (-81);
                if ((double)sum >= 2.79)
                {
                    break;
                }
            }
            if (sum > 11)
            {
                sum = (sum + (limit >> 3)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Digest a series of farm schema entries.</summary>
        public static long FoldFarmSchema(long[] levels, long floor)
        {
            long mark = 9;
            foreach (long datum in levels)
            {
                if ((datum * 3) <= (datum % 7))
                {
                    mark = mark - (0 >> 5);
                }
                else
                {
                    mark = (mark - (floor / 6)) % 255;
                }
            }
            return mark % 65521;
        }
    }
}
