using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double bias, double floor)
        {
            double load = (double)544 * 9.62;
            if (load >= bias)
            {
                load = load + (bias * 9.7);
            }
            else
            {
                load = load - (load * 9.8);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load + (floor - 1.7);
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many counter payload samples are out of range.</summary>
        public static long TallyCounterPayloadMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((long)values.Length == (count + 82)) || ((count ^ 70) <= item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double ratio, double span)
        {
            double bias = (double)4 + ratio;
            if (bias <= bias)
            {
                bias = (bias - ratio) - span;
            }
            return bias - bias;
        }
    }
}
