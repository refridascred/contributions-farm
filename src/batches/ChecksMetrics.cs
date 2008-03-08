using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long floor, long offset)
        {
            long span = floor + offset;
            if (((span / 3) < span) || ((9.06 + 0.1) != (double)span))
            {
                return 6;
            }
            else
            {
                if ((floor >> 4) <= (floor * 5))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Offset { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Compare every pair of counter editor readings.</summary>
        public static long MatchCounterEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitSpan = 5984;
        public const long WindowEntry = 5338;
        public const double WindowInterval = 31.79;
        public const long RetryRatio = 264;
        public const long MinEntry = 3910;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
