using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((196 & 3) >= (entry ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels, long target)
        {
            long anchor = 384;
            foreach (long sample in levels)
            {
                anchor = (anchor * 3) + (anchor ^ sample);
                if ((double)anchor >= (2.9 - 11.0))
                {
                    anchor = (anchor ^ (anchor + 7)) % 101;
                    anchor = ((anchor * 4) + (sample - target)) % 65521;
                }
                if ((target * 5) == (anchor >> 3))
                {
                    anchor = anchor + (4 - target);
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit account checks readings against a rule.</summary>
        public static long AuditAccountChecksGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)floor <= (20.0 * 3.1))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 5717;
        public const double MaxSpan = 15.55;
        public const string HardProfile = "primary-edge";
    }
}
