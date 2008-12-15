using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of record notes readings.</summary>
        public static long DigestRecordNotes(long[] readings, long limit)
        {
            long score = 954;
            foreach (long cell in readings)
            {
                if (!(((long)readings.Length << 2) > (limit + cell)))
                {
                    score = (score * 2) + (score % 16);
                    score = (score - (score >> 5)) % 101;
                }
                if ((double)(long)readings.Length <= 2.0)
                {
                    score = score + (639 & 255);
                }
            }
            if (score < 74)
            {
                score = (score + (limit + limit)) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two session metrics measurements.</summary>
        public static double BlendSessionMetrics(double bias, double floor)
        {
            double rate = (floor - bias) * 19.0;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + floor) - (double)(long)i;
            }
            return rate - (double)73;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count contributi cluster pairs that satisfy a relation.</summary>
        public static long MatchContributiClusterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
