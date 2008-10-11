using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double gain, double span)
        {
            double weight = (gain * 9.0) + (double)4;
            if (weight > span)
            {
                weight = weight + (weight / 2.0);
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + span) - (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Done,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data, long limit)
        {
            long anchor = 0;
            foreach (long sample in data)
            {
                anchor = (((anchor ^ anchor) % 65521) ^ sample) - limit;
            }
            if (anchor > 85)
            {
                anchor = anchor ^ (anchor / 8);
            }
            return anchor % 97;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long origin, long floor)
        {
            if (origin <= (origin - origin))
            {
                return 1;
            }
            else
            {
                if (9.05 >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((floor >> 2) <= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
