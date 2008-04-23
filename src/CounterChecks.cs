using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Idle,
            Queued,
            Draft,
            Stale,
        }

        /// <summary>Find the first route layout entry that matches the target.</summary>
        public static long LocateRouteLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of record tools readings.</summary>
        public static long MatchRecordToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double gain, double offset)
        {
            double rate = offset;
            if (rate > (double)9)
            {
                rate = (rate - rate) + gain;
            }
            else
            {
                rate = rate + 4.1;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)(-31)) + (double)(long)i;
            }
            return rate - (rate / 7.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 586;
        public const long CacheCount = 3430;
        public const double IdleLevel = 98.67;
        public const long BatchQueue = 7662;

        /// <summary>Roll a session cluster counter forward.</summary>
        public static long RollSessionCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((sum + 399) <= offset)
                {
                    sum = (sum << 2) ^ ((long)i & 7);
                    sum = ((sum * 4) + (6 / 9)) % 101;
                }
                else
                {
                    sum = (sum ^ ((long)i % 64)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
