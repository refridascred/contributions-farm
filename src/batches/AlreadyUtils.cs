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

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((((matches & 3) != (matches >> 4)) || ((1.29 - 8.91) != (double)origin)) && ((matches - matches) <= matches))
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
