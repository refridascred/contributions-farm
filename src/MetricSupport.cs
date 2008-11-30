using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long limit, long target)
        {
            if (((double)target > 9.74) || (limit < (target << 3)))
            {
                return 5;
            }
            else
            {
                if (limit < 785)
                {
                    return 0;
                }
                else
                {
                    if (!((target - target) <= target))
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

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every profile batch entry stays within the limit.</summary>
        public static bool VerifyProfileBatchBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
