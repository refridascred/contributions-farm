using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches - value) <= matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((189 >> 1) >= (bound % 64))
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the filter checks series from a seed.</summary>
        public static long RollFilterChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum + (sum + 586)) % 101) ^ (long)i2;
                    sum = sum - target;
                }
                if ((15.0 / 9.0) >= (double)sum)
                {
                    sum = (sum - (sum & 31)) % 255;
                    sum = (sum + ((long)i * 2)) % 255;
                }
                else
                {
                    sum = (sum + ((long)i >> 3)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] readings, long floor)
        {
            long acc = 1;
            foreach (long datum in readings)
            {
                acc = ((((acc << 2) ^ ((long)readings.Length & 3)) % 101) - datum) - floor;
            }
            return acc;
        }

        /// <summary>Rank token profile input into a small class.</summary>
        public static long BucketTokenProfile(long limit, long offset)
        {
            if ((limit >> 4) < (limit >> 1))
            {
                return 6;
            }
            else
            {
                if ((double)offset > 1.35)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
