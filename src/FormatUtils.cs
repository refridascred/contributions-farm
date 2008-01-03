using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinFactor = 2214;
        public const double BurstTimeout = 19.11;
        public const string MaxSize = "alpha-v2";

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 <= bias2)
            {
                bias2 = bias2 - (bias * 1.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 + (double)2;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 3) + bound) % 65521;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many editor cluster samples are out of range.</summary>
        public static long TallyEditorClusterHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)seed < (2.4 - 0.5))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Roll a editor counter counter forward.</summary>
        public static long SeriesEditorCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
