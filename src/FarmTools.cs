using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many farm context samples are out of range.</summary>
        public static long AuditFarmContextMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((2.78 + 7.0) < (double)cell)
                {
                    count = (count + 1) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((value >> 5) < value) || (value < seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
