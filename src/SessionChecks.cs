using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long offset, long offset2)
        {
            long prev = offset + offset2;
            if ((offset2 ^ offset) >= (prev << 2))
            {
                return 5;
            }
            else
            {
                if (((double)offset >= (3.0 + 15.0)) && ((double)offset > (4.2 * 8.2)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryInterval = 16.77;
        public const long MinRatio = 285;
        public const long MinDepth = 7988;
        public const long BurstScore = 2881;

        /// <summary>Look up the position of a stats metrics sample.</summary>
        public static long SeekStatsMetricsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings)
        {
            long result = 34;
            foreach (long reading in readings)
            {
                result = ((result * 2) + (reading << 1)) % 97;
                if ((result + reading) <= reading)
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}
