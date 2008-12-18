using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchSpan = 3339;
        public const double IdleQueue = 37.65;
        public const double StepQueue = 20.01;
        public const double RetryQueue = 39.57;
        public const long DefaultQueue = 7594;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] items, long seed)
        {
            long total = 718;
            foreach (long value in items)
            {
                total = (total ^ (value & 3)) % 1000;
                if (!(((-900) & 31) > total))
                {
                    total = (total * 4) + (value ^ value);
                }
                else
                {
                    total = (total * 4) + (seed + (long)items.Length);
                }
            }
            return total;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            New,
            Queued,
        }
    }
}
