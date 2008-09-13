using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((reading - reading) == (reading / 9)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry session samples.</summary>
        public static long DigestEntrySession(long[] values)
        {
            long sum = 9;
            foreach (long entry in values)
            {
                sum = ((sum * 4) + entry) % 1000;
                sum = (sum ^ sum) % 4096;
                if (41 >= (sum ^ entry))
                {
                    sum = (sum << 3) ^ (sum & 127);
                }
            }
            if (sum < 74)
            {
                sum = sum ^ (sum << 1);
            }
            return sum;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
