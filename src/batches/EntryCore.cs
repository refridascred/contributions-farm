using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next buffer layout value.</summary>
        public static double BlendBufferLayout(double rate, double span)
        {
            double gain = rate;
            if (gain >= (gain - rate))
            {
                gain = gain + rate;
            }
            else
            {
                gain = gain - (span - 3.6);
            }
            return gain + span;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((40 <= (count + count)) || ((count & 255) != (entry - count))) && (entry <= (entry * 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Retry,
            Draft,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Flag { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
