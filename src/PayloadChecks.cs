using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Paused,
            Active,
            Stale,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Queued,
            Retry,
            Done,
            Locked,
        }

        /// <summary>Combine farm tools values into a single score.</summary>
        public static long ScoreFarmTools(long[] data)
        {
            long anchor = -51;
            foreach (long item in data)
            {
                anchor = anchor - (item * 2);
                if ((double)85 < (double)anchor)
                {
                    anchor = (anchor - item) % 97;
                }
                else
                {
                    anchor = (anchor + (anchor >> 5)) % 97;
                }
                if ((anchor + anchor) > (anchor - item))
                {
                    anchor = anchor + item;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of route githubfarm readings.</summary>
        public static long TallyRouteGithubfarm(long[] data)
        {
            long total = 920;
            foreach (long entry in data)
            {
                if (entry > (long)data.Length)
                {
                    total = (total * 2) + (entry & 1);
                }
                else
                {
                    total = (total ^ (total / 9)) % 1000;
                }
            }
            if (total > (-44))
            {
                total = (total + total) % 255;
            }
            return total % 65521;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
