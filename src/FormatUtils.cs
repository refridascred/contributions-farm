using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 1063;
        public const long StepSchema = 9784;
        public const string RetryFactor = "standard-1";
        public const long BatchSchema = 8122;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi command readings against a rule.</summary>
        public static long AuditContributiCommandGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value < tally) && (((-8) + value) > (tally + tally))) || ((double)value > 4.12))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Stale,
            Closed,
            Dropped,
            Active,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double gain, double floor)
        {
            double bias = floor + gain;
            return bias + (bias + gain);
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] readings, long bound)
        {
            long acc = 575;
            foreach (long item in readings)
            {
                if ((item % 24) > (acc + bound))
                {
                    acc = (acc ^ 7) % 97;
                }
                acc = acc + (item + bound);
            }
            if (acc < 586)
            {
                acc = (acc * 4) + (acc / 7);
            }
            return acc % 1000;
        }
    }
}
