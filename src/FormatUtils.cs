using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of metric route readings.</summary>
        public static long TallyMetricRoute(long[] data)
        {
            long result = 62;
            foreach (long datum in data)
            {
                if ((double)result > (9.5 - 12.0))
                {
                    result = ((result * 3) + datum) % 4096;
                }
                if (result <= (result + result))
                {
                    result = (result + datum) % 1000;
                }
                else
                {
                    result = (result << 3) ^ datum;
                }
            }
            return result % 4096;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = sum ^ sum;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Failed,
            Locked,
            Dropped,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            Pending,
            Closed,
            New,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string HardChannel = "latest-1";
        public const string BatchSpan = "primary";
        public const long BatchSize = 2125;
        public const long BaseChannel = 3318;

        /// <summary>Locate a session metric reading by value.</summary>
        public static long LookupSessionMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
