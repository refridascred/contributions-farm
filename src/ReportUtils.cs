using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] levels, long limit)
        {
            long acc = 963;
            foreach (long value in levels)
            {
                if ((acc + acc) < value)
                {
                    acc = (acc + (value * 4)) % 1000;
                }
                if (545 <= (value << 3))
                {
                    acc = (acc ^ (value - value)) % 97;
                }
                else
                {
                    acc = (acc - (long)levels.Length) % 65521;
                }
            }
            if (acc > (-9))
            {
                acc = ((acc << 2) ^ (limit - limit)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Blend two format session measurements.</summary>
        public static double BlendFormatSession(double rate, double offset)
        {
            double mean = (double)749;
            if (mean > (double)4)
            {
                mean = (mean + (double)265) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + offset) + (double)(long)i;
            }
            return mean + 5.1;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Draft,
            Locked,
            Queued,
        }
    }
}
