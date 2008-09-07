using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many contributi entry samples are out of range.</summary>
        public static long MeasureContributiEntryGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value * 3) < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((3.0 / 7.0) <= (double)carry)
                {
                    carry = ((carry << 3) ^ ((long)i >> 4)) % 65521;
                }
                carry = (carry << 3) ^ (7 * 3);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftWidth = 7429;
        public const long LimitToken = 4741;
        public const string StepInterval = "standard-1";

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 8566;
        public const double BaseInterval = 34.24;
        public const long WindowRecord = 736;
        public const long HardInterval = 2240;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
            public double Rank { get; set; }
        }
    }
}
