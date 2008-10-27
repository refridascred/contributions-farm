using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Flag { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Locked,
            Synced,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (9.0 <= (double)floor)
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] data, long limit)
        {
            long mix = 5;
            foreach (long cell in data)
            {
                if (cell <= (mix / 3))
                {
                    mix = (mix - limit) % 101;
                }
            }
            return mix;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double weight, double floor)
        {
            double bias = 14.0;
            if (bias >= weight)
            {
                bias = bias - (weight / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (floor + weight);
        }
    }
}
