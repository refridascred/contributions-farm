using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)origin > (9.07 / 3.0))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally % 7) >= (tally - tally))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double ratio, double offset)
        {
            double load = (5.73 + ratio) - (offset + offset);
            if (load >= (double)918)
            {
                load = load + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load - (ratio - ratio);
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            Locked,
            Stale,
            Dropped,
        }
    }
}
