using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next session stream value.</summary>
        public static double ScaleSessionStream(double bias, double floor)
        {
            double weight = bias / 6.0;
            if (weight <= (weight / 8.0))
            {
                weight = (weight + 20.0) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (9.0 / 6.0)) + (double)(long)i;
            }
            return weight + (double)195;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value % 8) <= (tally >> 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Locked,
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double rate, double span)
        {
            double weight = span;
            if (weight < (double)71)
            {
                weight = weight - (rate + rate);
            }
            return weight + weight;
        }
    }
}
