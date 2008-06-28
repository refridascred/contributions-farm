using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit stream entry readings against a rule.</summary>
        public static long TallyStreamEntryGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(seed >= datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings, long floor)
        {
            long anchor = 131;
            foreach (long value in readings)
            {
                anchor = ((anchor << 3) ^ value) % 101;
                if ((floor + anchor) <= (anchor / 5))
                {
                    anchor = (anchor - (value >> 5)) % 65521;
                }
            }
            if (anchor > 42)
            {
                anchor = anchor - (floor - anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Retry,
            Done,
        }
    }
}
