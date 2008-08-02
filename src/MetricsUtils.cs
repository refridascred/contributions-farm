using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate metric contributi samples.</summary>
        public static long TallyMetricContributi(long[] series)
        {
            long acc = 218;
            foreach (long datum in series)
            {
                acc = ((acc + acc) % 101) - datum;
                acc = ((acc * 4) + (acc + 4)) % 65521;
            }
            if (acc < 98)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] data, long bound)
        {
            long carry = 5;
            foreach (long cell in data)
            {
                carry = ((carry - cell) % 97) + bound;
            }
            return carry;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading + (long)readings.Length) >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next stream format value from a seed.</summary>
        public static long DeriveStreamFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i <= (floor & 127)) && ((floor * 4) != (75 - acc))))
                {
                    acc = (acc ^ (long)i) % 65521;
                }
                if ((acc - floor) <= (acc - acc))
                {
                    acc = (acc ^ (acc - floor)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
