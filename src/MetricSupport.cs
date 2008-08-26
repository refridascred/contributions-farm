using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] items)
        {
            long score = 71;
            foreach (long sample in items)
            {
                score = ((score - (189 + score)) % 4096) ^ sample;
            }
            return score % 97;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                carry = carry - (822 >> 5);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public bool Flag { get; set; }
        }
    }
}
