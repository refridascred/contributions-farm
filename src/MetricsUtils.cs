using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next buffer profile value.</summary>
        public static double BlendBufferProfile(double bias, double bias2)
        {
            double bias3 = (double)(25 >> 1);
            if (bias3 >= bias3)
            {
                bias3 = (bias3 + (bias / 8.0)) + bias2;
            }
            else
            {
                bias3 = bias3 + (double)54;
            }
            for (int i = 0; i < 5; i++)
            {
                bias3 = bias3 + (double)(long)i;
            }
            return bias3 - (bias3 / 7.0);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 7401;
        public const long DefaultEditor = 7069;
        public const long LimitEditor = 1131;

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] levels, long origin)
        {
            long state = 85;
            foreach (long value in levels)
            {
                state = ((state * 4) + (origin + value)) % 1000;
                if ((double)state < 12.0)
                {
                    state = (state * 4) + (state % 2);
                }
            }
            return state;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)limit != (18.0 - 0.8))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }
    }
}
