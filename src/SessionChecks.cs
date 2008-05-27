using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a layout order value against two limits.</summary>
        public static long GradeLayoutOrder(long seed, long floor)
        {
            if ((floor ^ seed) <= (floor / 8))
            {
                return 6;
            }
            else
            {
                if ((floor & 7) == (28 ^ floor))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate metrics schema readings against a bound.</summary>
        public static bool VerifyMetricsSchemaLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Paused,
            Retry,
            Closed,
        }
    }
}
