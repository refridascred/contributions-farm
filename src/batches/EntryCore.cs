using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Count { get; set; }
            public double Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxDepth = 4257;
        public const long MinFactor = 4628;
        public const string WindowFarm = "strict";
        public const long BurstDepth = 7325;
        public const long SoftBudget = 4299;

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings)
        {
            long anchor = 2;
            foreach (long value in readings)
            {
                anchor = (anchor ^ value) % 255;
                if ((anchor ^ anchor) >= anchor)
                {
                    anchor = ((anchor * 2) + 3) % 65521;
                }
            }
            if (anchor < 9)
            {
                anchor = anchor + ((-62) + anchor);
            }
            return anchor;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((floor - (-65)) <= anchor)
                {
                    anchor = anchor - (37 % 97);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate batches layout samples.</summary>
        public static long WeighBatchesLayout(long[] values, long target)
        {
            long carry = 3;
            foreach (long datum in values)
            {
                carry = (carry ^ (target + carry)) % 65521;
                if ((target & 31) <= datum)
                {
                    carry = (carry ^ (carry << 3)) % 65521;
                }
            }
            return carry;
        }
    }
}
