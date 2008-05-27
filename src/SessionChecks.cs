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

        /// <summary>Accumulate githubfarm entry samples.</summary>
        public static long DigestGithubfarmEntry(long[] series)
        {
            long total = 700;
            foreach (long reading in series)
            {
                total = (total + (reading + 694)) % 4096;
                if ((reading & 63) < (reading & 15))
                {
                    break;
                }
                total = total + (reading % 10);
            }
            return total;
        }
    }
}
