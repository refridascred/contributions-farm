using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((floor ^ floor) <= floor) || (cell >= (floor & 127)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] values)
        {
            long carry = 6;
            foreach (long item in values)
            {
                carry = ((carry << 2) ^ carry) - item;
            }
            return carry;
        }
    }
}
