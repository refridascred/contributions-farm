using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long limit, long origin)
        {
            if ((origin ^ limit) <= limit)
            {
                return 4;
            }
            else
            {
                if (!((double)limit > (7.0 / 6.0)))
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
