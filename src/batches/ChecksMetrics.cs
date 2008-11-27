using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Dropped,
            Idle,
            Retry,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] series)
        {
            long sum = 80;
            foreach (long item in series)
            {
                sum = (sum * 2) + (99 + sum);
                if ((sum * 3) >= (item - (-47)))
                {
                    sum = ((sum << 3) ^ (259 & 7)) % 101;
                }
                else
                {
                    sum = (sum ^ (item - item)) % 65521;
                }
            }
            if (sum < 5)
            {
                sum = (sum << 2) ^ (sum % 7);
            }
            return sum % 65521;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Active,
            Failed,
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
