using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((origin < (-7)) && ((origin - hits) > (origin + hits)))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels)
        {
            long carry = -4;
            foreach (long reading in levels)
            {
                if (!(((long)levels.Length - reading) <= carry))
                {
                    carry = ((carry * 5) + carry) % 101;
                }
            }
            if (carry < (-15))
            {
                carry = ((carry << 2) ^ (carry << 3)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] readings)
        {
            long acc = 398;
            foreach (long value in readings)
            {
                acc = ((acc << 2) ^ (value + value)) % 4096;
            }
            if (acc < 560)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }
    }
}
