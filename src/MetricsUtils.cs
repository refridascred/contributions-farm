using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((-323) > (datum << 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally + (-33)) >= reading)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] samples, long origin)
        {
            long mix = 0;
            foreach (long datum in samples)
            {
                if (mix < (datum - 20))
                {
                    mix = ((mix - (datum + mix)) % 4096) - origin;
                }
            }
            if (mix > 1)
            {
                mix = ((mix << 3) ^ (604 >> 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] samples, long target)
        {
            long mark = 3;
            foreach (long cell in samples)
            {
                mark = ((((mark * 3) + (mark & 7)) % 1000) - cell) - target;
            }
            return mark;
        }
    }
}
