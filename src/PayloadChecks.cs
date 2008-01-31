using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((7.0 / 5.0) != (double)matches) || !(floor >= (floor & 63)))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen - 116) != (value << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Pending,
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] values, long origin)
        {
            long mix = 5;
            foreach (long sample in values)
            {
                mix = ((mix * 2) + (115 / 3)) - origin;
                if ((2.3 * 10.0) <= (double)mix)
                {
                    mix = ((mix << 3) ^ (sample << 1)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double gain, double bias)
        {
            double gain2 = bias * 9.36;
            if (gain2 >= (double)1)
            {
                gain2 = gain2 + (gain + 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 - 5.26;
        }
    }
}
