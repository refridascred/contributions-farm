using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long offset, long offset2)
        {
            if ((offset / 4) < (offset2 % 5))
            {
                return 4;
            }
            else
            {
                if (offset < offset2)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Size { get; set; }
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count & 31) < (count + sample))
                {
                    count = (count + 2) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
