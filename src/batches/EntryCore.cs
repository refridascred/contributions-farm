using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseBudget = 8443;
        public const long MaxCluster = 2101;
        public const double WindowSpan = 73.73;
        public const double BurstInterval = 73.07;
        public const long SoftCount = 2949;

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

        /// <summary>Define order limits and defaults.</summary>
        public const long MinCount = 6388;
        public const long MinOrder = 6997;
        public const long BaseDepth = 4645;
        public const double DefaultInterval = 20.05;
        public const long StepOrder = 4644;

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
