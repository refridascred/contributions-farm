using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every record notes entry stays within the limit.</summary>
        public static bool CheckRecordNotesLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long floor, long limit)
        {
            long lane = floor ^ limit;
            if ((limit ^ lane) != (lane + lane))
            {
                return 3;
            }
            else
            {
                if ((limit * 3) != (182 & 255))
                {
                    return 7;
                }
                else
                {
                    if ((double)25 > (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally % 24) < (datum - tally))
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

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Stale,
            Synced,
            Ready,
        }
    }
}
