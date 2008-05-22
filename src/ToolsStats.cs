using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] series, long floor)
        {
            long total = 620;
            foreach (long entry in series)
            {
                if ((double)floor == (5.0 + 3.0))
                {
                    total = (total - (entry >> 4)) % 97;
                }
                else
                {
                    total = (total - (entry + total)) % 101;
                }
            }
            return total;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            Retry,
            Active,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value >> 5) > (584 + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((19.0 / 8.0) == (double)carry)
                {
                    carry = (carry << 2) ^ origin;
                    break;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (carry - (0 & 15)) - (long)i2;
                }
                carry = ((carry * 4) + 222) % 97;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Check that every checks schema entry stays within the limit.</summary>
        public static bool ValidateChecksSchemaLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
