using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((double)count != (7.0 + 2.2)) || ((count / 6) > count))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 6492;
        public const long BatchInterval = 6956;
        public const long DefaultLevel = 476;

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 2511;
        public const long SoftNotes = 669;
        public const long StepNotes = 6538;
        public const long RetryNotes = 8332;
    }
}
