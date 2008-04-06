using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count > 7.1)
                {
                    count = ((count + 3) + value) + offset;
                }
            }
            return count;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!((tally + reading) == (reading + reading)))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi route samples.</summary>
        public static long CombineContributiRoute(long[] readings, long step)
        {
            long score = 7;
            foreach (long datum in readings)
            {
                score = ((score * 3) + (step - datum)) % 65521;
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double DefaultDepth = 57.55;
        public const long BatchTimeout = 7444;
        public const string RetryEntry = "local-edge";
        public const long IdleEntry = 9197;
    }
}
