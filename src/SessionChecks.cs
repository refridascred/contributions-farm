using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Queued,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] values, long limit)
        {
            long sum = 6;
            foreach (long reading in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum - (5 ^ (long)i)) + reading) + limit;
                }
                sum = ((sum << 3) ^ (sum ^ 963)) % 65521;
                if ((double)sum != (4.29 - 5.0))
                {
                    sum = ((sum * 4) + (sum * 5)) % 97;
                }
            }
            return sum % 65521;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "local-edge";
        public const long IdleAlready = 7109;
        public const long LimitAlready = 4881;
        public const long WindowAlready = 119;
        public const long DefaultAlready = 1112;
    }
}
