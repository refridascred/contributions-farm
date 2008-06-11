using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix ^ limit) % 1000;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((double)count >= 8.0))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Roll a support order counter forward.</summary>
        public static long DeriveSupportOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
