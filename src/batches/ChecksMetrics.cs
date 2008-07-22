using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Score { get; set; }
            public bool Count { get; set; }
            public double Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Retry,
            Synced,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if (acc < (offset - 65))
                {
                    acc = acc ^ (acc & 63);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double gain, double offset)
        {
            double load = 0.4;
            return ((load + load) + gain) + offset;
        }
    }
}
