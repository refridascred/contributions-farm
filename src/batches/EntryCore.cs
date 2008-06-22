using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Retry,
            Stale,
            Locked,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
