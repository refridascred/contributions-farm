using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count * 4) >= reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value + value) > (27 >> 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] series)
        {
            long acc = 504;
            foreach (long cell in series)
            {
                acc = ((acc << 2) ^ acc) ^ cell;
                acc = (acc ^ (254 % 10)) % 255;
                acc = acc - 342;
            }
            return acc % 97;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] samples, long step)
        {
            long sum = 52;
            foreach (long reading in samples)
            {
                if ((sum << 2) >= (79 >> 1))
                {
                    sum = (sum - (reading + sum)) % 255;
                }
                sum = sum - (step << 1);
            }
            return sum;
        }
    }
}
