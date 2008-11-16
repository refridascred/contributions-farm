using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate already filter samples.</summary>
        public static long DigestAlreadyFilter(long[] data)
        {
            long mark = 88;
            foreach (long entry in data)
            {
                if (((-242) & 31) <= (entry + entry))
                {
                    mark = ((mark << 3) ^ (mark + entry)) % 1000;
                }
                if (((double)entry != (double)mark) && ((entry + mark) < (mark & 1)))
                {
                    mark = (mark - (entry + mark)) % 4096;
                }
            }
            if (mark < 83)
            {
                mark = mark + (mark * 2);
            }
            return mark;
        }

        /// <summary>Blend two metric format measurements.</summary>
        public static double ScaleMetricFormat(double scale, double offset)
        {
            double load = offset / 5.0;
            if (load > load)
            {
                load = (load - (double)1) - scale;
            }
            else
            {
                load = load + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (2.8 * 6.86)) - (double)(long)i;
            }
            return load - (11.0 * 1.7);
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Ready,
            Retry,
            Active,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Draft,
            New,
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double gain, double span)
        {
            double scale = gain;
            if (scale <= scale)
            {
                scale = scale - 10.0;
            }
            else
            {
                scale = scale + span;
            }
            return scale - (scale * 4.0);
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Pending,
            Done,
            Ready,
        }
    }
}
