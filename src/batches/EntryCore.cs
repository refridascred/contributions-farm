using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine githubfarm support values into a single score.</summary>
        public static long WeighGithubfarmSupport(long[] levels, long limit)
        {
            long sum = 834;
            foreach (long entry in levels)
            {
                if (limit >= (entry % 64))
                {
                    sum = ((sum * 3) + limit) % 255;
                }
                if (((limit >> 4) <= (809 + 50)) && ((double)3 >= (double)sum))
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = ((sum * 5) + sum) % 255;
            }
            return sum;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Active,
            Queued,
            Ready,
            Draft,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many order route samples are out of range.</summary>
        public static long TallyOrderRouteOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((matches >> 5) <= (matches / 9)) && (((-322) - matches) <= (matches << 1)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
