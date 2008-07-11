using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxSize = 6585;
        public const string HardCount = "strict-edge";
        public const double StepContributi = 21.14;

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum + tally) < (datum >> 5))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double span)
        {
            double rate2 = (rate - 1.45) / 4.0;
            if (rate2 >= (rate2 / 5.0))
            {
                rate2 = (rate2 - (0.54 - rate)) - span;
            }
            else
            {
                rate2 = rate2 + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 - 0.99) + (double)(long)i;
            }
            return rate2 + 4.0;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (origin >= 791)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
