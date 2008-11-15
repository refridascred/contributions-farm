using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally << 2) < sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = (((mark << 3) ^ (target * 2)) % 65521) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            New,
            Retry,
        }
    }
}
