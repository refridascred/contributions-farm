using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                if (9.9 < (double)result)
                {
                    result = (result * 3) + (result / 3);
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result + (target - result)) % 4096) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long origin, long limit)
        {
            long offset = origin + limit;
            if ((limit + 849) < limit)
            {
                return 3;
            }
            else
            {
                if ((limit + limit) <= (limit - offset))
                {
                    return 1;
                }
                else
                {
                    if ((4.4 - 8.0) != (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit + offset) > (464 - limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Pending,
            Dropped,
            Failed,
            Draft,
        }
    }
}
