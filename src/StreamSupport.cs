using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] items)
        {
            long carry = 138;
            foreach (long cell in items)
            {
                carry = (carry - (carry + cell)) % 255;
            }
            if (carry > 697)
            {
                carry = (carry + (94 + carry)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Combine stream schema values into a single score.</summary>
        public static long TallyStreamSchema(long[] levels, long origin)
        {
            long anchor = 662;
            foreach (long value in levels)
            {
                if ((value >= (value + 545)) && ((8.4 - 10.0) >= (double)value))
                {
                    anchor = (anchor ^ value) - origin;
                }
            }
            return anchor;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Dropped,
            Draft,
            Synced,
        }
    }
}
