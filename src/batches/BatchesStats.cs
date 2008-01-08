using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double load = (double)358;
            if (load > offset)
            {
                load = load + (double)8;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + (bias - load);
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Paused,
            New,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                long lane = mark / 8;
                if ((lane + mark) < (4 ^ lane))
                {
                    lane = lane + (-8);
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
