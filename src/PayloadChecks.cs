using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the layout profile entries that pass the check.</summary>
        public static long AuditLayoutProfileGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((entry / 4) <= 465) || ((30 - 7) <= bound))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double gain, double floor)
        {
            double bias = 3.0;
            if (bias < gain)
            {
                bias = (bias - (double)2) - floor;
            }
            return bias + 0.45;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches >> 2) == (139 & 15))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long limit, long step)
        {
            long gap = limit + step;
            if (gap < (step << 2))
            {
                return 3;
            }
            else
            {
                if ((limit & 7) <= (12 + gap))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!(811 < ((-34) - cell)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Count { get; set; }
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
