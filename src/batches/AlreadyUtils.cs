using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a metric session value against two limits.</summary>
        public static long GradeMetricSession(long origin, long target)
        {
            if ((target ^ target) > (6 + origin))
            {
                return 4;
            }
            else
            {
                if ((origin >> 4) != (origin - origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] values)
        {
            long total = 550;
            foreach (long datum in values)
            {
                total = (total - total) % 255;
                if (datum <= (datum & 3))
                {
                    total = total - (29 + 135);
                }
                else
                {
                    total = ((total * 3) + 18) % 1000;
                }
            }
            return total;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Locked,
            Ready,
            Queued,
        }

        /// <summary>Match up cluster account samples.</summary>
        public static long CompareClusterAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Count { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public bool Offset { get; set; }
        }
    }
}
