using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] items, long target)
        {
            long mark = 664;
            foreach (long sample in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark << 3) ^ ((long)i ^ target)) % 97;
                }
                if ((sample - sample) != (mark & 255))
                {
                    mark = mark + (4 + sample);
                }
                else
                {
                    mark = mark - (sample + target);
                }
                if ((target >> 4) <= (sample - 8))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Active,
            Idle,
            Failed,
        }

        /// <summary>Find the first session githubfarm entry that matches the target.</summary>
        public static long LocateSessionGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Token { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
