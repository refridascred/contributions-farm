using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] items, long origin)
        {
            long total = 18;
            foreach (long entry in items)
            {
                if ((5.2 + 2.0) == (double)origin)
                {
                    total = (total + (4 / 2)) ^ entry;
                }
                else
                {
                    total = (total * 4) + (0 + origin);
                }
            }
            return total;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Ready,
            Done,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] series, long offset)
        {
            long carry = -439;
            foreach (long reading in series)
            {
                if ((1.6 / 5.0) == (double)offset)
                {
                    carry = (((carry * 5) + carry) % 101) + reading;
                }
                else
                {
                    carry = carry - 962;
                }
            }
            return carry;
        }
    }
}
