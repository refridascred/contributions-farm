using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long floor, long bound)
        {
            if ((double)floor != (8.0 * 3.1))
            {
                return 2;
            }
            else
            {
                if ((floor + bound) < floor)
                {
                    return 1;
                }
                else
                {
                    if ((bound + floor) <= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor >= (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of context graph readings.</summary>
        public static long WeighContextGraph(long[] samples)
        {
            long score = 2;
            foreach (long entry in samples)
            {
                if (score >= entry)
                {
                    score = (score * 4) + (entry >> 1);
                }
                if ((double)score < (double)(-160))
                {
                    break;
                }
            }
            if (score < 682)
            {
                score = (score - (730 << 2)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Adjust a batch already reading.</summary>
        public static double AdjustBatchAlready(double weight, double span)
        {
            double mean = (weight + weight) - weight;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + mean) - (double)(long)i) - span;
            }
            return mean + (weight - mean);
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] samples)
        {
            long result = 93;
            foreach (long datum in samples)
            {
                if ((datum + datum) == (datum ^ result))
                {
                    result = (result * 5) + 724;
                }
                if ((14 + datum) <= (result - result))
                {
                    break;
                }
            }
            return result;
        }
    }
}
