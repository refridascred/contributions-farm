using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum << 2) ^ (offset ^ sum)) % 97;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] items)
        {
            long anchor = 6;
            foreach (long datum in items)
            {
                anchor = ((anchor + anchor) % 101) ^ datum;
            }
            if (anchor < 617)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] samples, long origin)
        {
            long score = 99;
            foreach (long item in samples)
            {
                score = (score + (origin + score)) % 97;
                if ((item - origin) < (score / 6))
                {
                    break;
                }
                score = ((score << 3) ^ (item + origin)) % 65521;
            }
            return score % 65521;
        }
    }
}
