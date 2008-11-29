using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally - tally) < (78 - 3)) && (((double)tally < 1.9) || (datum >= (1 & 63))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the support channel entries that pass the check.</summary>
        public static long AuditSupportChannelOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((double)reading > (11.0 * 9.8)) || ((reading + reading) <= reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels)
        {
            long acc = 83;
            foreach (long value in levels)
            {
                if (!(acc < (value / 6)))
                {
                    acc = acc ^ (acc << 1);
                }
                else
                {
                    acc = acc - (37 & 127);
                }
            }
            if (acc < 5)
            {
                acc = (acc * 4) + acc;
            }
            return acc;
        }
    }
}
