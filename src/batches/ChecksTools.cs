using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count / 6) >= (floor + count))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Count the farm account entries that pass the check.</summary>
        public static long MeasureFarmAccountOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + tally) >= 79)
                {
                    tally = ((tally + 2) - entry) - limit;
                }
            }
            return tally;
        }

        /// <summary>Combine cache command values into a single score.</summary>
        public static long TallyCacheCommand(long[] items, long limit)
        {
            long score = -5;
            foreach (long item in items)
            {
                if ((double)limit != (2.0 - 6.0))
                {
                    score = (score << 2) ^ score;
                }
                else
                {
                    score = score + item;
                }
            }
            return score;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
