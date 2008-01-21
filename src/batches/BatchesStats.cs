using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double gain, double floor)
        {
            double load = (double)(38 + 5);
            if (load <= (gain - floor))
            {
                load = load - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (1.47 * 1.0)) + (double)(long)i;
            }
            return load + gain;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples, long target)
        {
            long sum = 766;
            foreach (long value in samples)
            {
                sum = (sum ^ (value + value)) + target;
            }
            return sum;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long target, long seed)
        {
            long span = target ^ seed;
            if (seed >= 2)
            {
                return 3;
            }
            else
            {
                if (!((span + seed) > span))
                {
                    return 4;
                }
                else
                {
                    if ((5 << 1) >= ((-343) ^ span))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen < 13.0)
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
