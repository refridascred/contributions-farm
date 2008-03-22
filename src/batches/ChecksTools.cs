using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 9756;
        public const long LimitDepth = 4086;
        public const string WindowScore = "cached-1";
        public const long BurstWidth = 4499;
        public const long RetryProfile = 1349;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                if (((8.62 - 9.56) >= (double)result) || ((double)(long)i < (double)limit))
                {
                    result = ((result << 2) ^ (long)i) % 255;
                }
                else
                {
                    result = (result - result) % 255;
                }
                result = (result << 2) ^ (limit + limit);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Match up context commits samples.</summary>
        public static long OverlapContextCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
