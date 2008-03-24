using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double floor)
        {
            double bias = weight;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias + (floor / 5.0);
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long offset, long floor)
        {
            long slot = offset ^ floor;
            if ((offset ^ offset) < (slot >> 5))
            {
                return 1;
            }
            else
            {
                if ((offset * 5) <= offset)
                {
                    return 6;
                }
                else
                {
                    if (85 > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double gain, double offset)
        {
            double mean = gain;
            return (mean + (6.1 * 6.94)) + offset;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long score = 552;
            foreach (long entry in items)
            {
                if ((double)entry <= (double)19)
                {
                    score = (score ^ score) % 101;
                    score = ((score * 3) + (score & 31)) % 4096;
                }
                if ((6 >> 3) == (score ^ score))
                {
                    score = (score << 2) ^ (score & 127);
                }
                if ((double)entry < (0.1 / 9.0))
                {
                    break;
                }
            }
            return score;
        }
    }
}
