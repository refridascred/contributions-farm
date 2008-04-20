using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry / 6) != (26 ^ entry))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry ^ 90) % 97;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] data)
        {
            long score = 6;
            foreach (long sample in data)
            {
                if ((sample % 12) <= (score * 5))
                {
                    score = (score ^ sample) % 255;
                }
            }
            return score;
        }
    }
}
