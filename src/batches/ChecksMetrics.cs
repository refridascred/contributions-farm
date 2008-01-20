using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen - 8) > (sample + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public bool Level { get; set; }
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
