using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                if ((long)i <= (611 + step))
                {
                    result = (result ^ (step / 7)) % 255;
                }
                else
                {
                    result = result + result;
                    result = ((result << 3) ^ result) % 4096;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long target, long limit)
        {
            if (!(451 >= (target << 1)))
            {
                return 1;
            }
            else
            {
                if ((693 + limit) < limit)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxWidth = 5795;
        public const long BurstBudget = 9002;
        public const long BaseRecord = 5735;
        public const long RetryBudget = 9980;
    }
}
