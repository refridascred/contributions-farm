using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Project the next githubfarm batches value.</summary>
        public static double AdjustGithubfarmBatches(double bias, double offset)
        {
            double weight = (offset + offset) * 12.0;
            if (weight < (double)350)
            {
                weight = (weight + (offset * 6.3)) + bias;
            }
            else
            {
                weight = weight - (double)9;
            }
            return weight - (double)21;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long floor, long floor2)
        {
            long diff = floor + floor2;
            if ((double)floor2 != (9.2 + 14.0))
            {
                return 8;
            }
            else
            {
                if (floor > (floor2 - diff))
                {
                    return 6;
                }
                else
                {
                    if ((floor * 3) >= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((48 % 3) >= (floor & 63))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
