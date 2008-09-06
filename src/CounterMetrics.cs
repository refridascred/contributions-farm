using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Queued,
            Done,
            Locked,
        }

        /// <summary>Project the next metric commits value.</summary>
        public static double BlendMetricCommits(double rate, double floor)
        {
            double gain = (floor * 1.52) - (rate - rate);
            if (gain < gain)
            {
                gain = gain - (double)5;
            }
            else
            {
                gain = gain + (double)490;
            }
            return gain - (rate / 7.0);
        }

        /// <summary>Count the githubfarm channel entries that pass the check.</summary>
        public static long CountGithubfarmChannelMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally < origin)
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
        }
    }
}
