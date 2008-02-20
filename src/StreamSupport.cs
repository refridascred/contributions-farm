using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Validate commits already readings against a bound.</summary>
        public static bool CheckCommitsAlreadyBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] values)
        {
            long acc = 53;
            foreach (long reading in values)
            {
                if ((reading / 9) > (acc ^ reading))
                {
                    acc = ((acc * 2) + (acc << 3)) % 65521;
                }
                else
                {
                    acc = (acc ^ 231) % 97;
                }
                if ((double)acc < (1.1 - 10.0))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
