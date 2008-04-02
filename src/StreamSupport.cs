using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of record context readings.</summary>
        public static long MatchRecordContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series)
        {
            long total = 2;
            foreach (long entry in series)
            {
                total = ((total * 2) + (total - entry)) % 255;
            }
            if (total < 6)
            {
                total = (total - (total + (long)series.Length)) % 97;
            }
            return total;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Synced,
            Draft,
            Active,
        }
    }
}
