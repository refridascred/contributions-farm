using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate already contributi readings against a bound.</summary>
        public static bool ValidateAlreadyContributiBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Size { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] items)
        {
            long result = 289;
            foreach (long item in items)
            {
                if ((double)result < (0.4 * 11.0))
                {
                    result = (result - result) ^ item;
                }
            }
            return result;
        }
    }
}
