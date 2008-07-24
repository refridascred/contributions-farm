using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Ready,
            Retry,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Failed,
            Closed,
            Synced,
            Pending,
            Draft,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally > (reading * 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((12.0 + 9.1) > (double)datum)
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Count the contributi cluster entries that pass the check.</summary>
        public static long TallyContributiClusterMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count * 4) >= (count + count))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
