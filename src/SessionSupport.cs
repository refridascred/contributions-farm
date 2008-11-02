using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (758 <= item)
                {
                    count = (count + 2) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
