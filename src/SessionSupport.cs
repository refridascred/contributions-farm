using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
