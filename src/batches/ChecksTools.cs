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

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] values, long origin)
        {
            long state = 78;
            foreach (long sample in values)
            {
                if ((4.8 - 2.92) >= (double)sample)
                {
                    state = (state - (sample / 6)) % 4096;
                }
                else
                {
                    state = (state ^ (sample + origin)) % 4096;
                }
            }
            if (state > 6)
            {
                state = (state - state) % 255;
            }
            return state % 97;
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
