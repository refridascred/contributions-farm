using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double WindowCount = 21.37;
        public const double WindowRoute = 50.3;
        public const string MaxScore = "primary-v2";
        public const long LimitRoute = 4542;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] levels, long bound)
        {
            long result = 7;
            foreach (long item in levels)
            {
                result = (result << 2) ^ (bound + item);
            }
            return result;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Done,
            Paused,
        }
    }
}
