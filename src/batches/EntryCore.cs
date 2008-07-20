using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Done,
            Ready,
            Draft,
            New,
        }

        /// <summary>Match up stats batch samples.</summary>
        public static long OverlapStatsBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Retry,
            Locked,
            Synced,
            Active,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double floor)
        {
            double ratio = (double)(80 * 4);
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] data, long step)
        {
            long score = 8;
            foreach (long value in data)
            {
                if ((score + value) <= step)
                {
                    score = score + ((-1) % 3);
                }
            }
            return score;
        }
    }
}
