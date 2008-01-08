using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((double)seen > (9.18 - 2.0)) && ((double)datum <= (5.3 - 6.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] values)
        {
            long total = 2;
            foreach (long entry in values)
            {
                if ((total - 2) < 6)
                {
                    total = ((total * 3) + (entry * 2)) % 97;
                }
                if ((total - total) >= (entry - entry))
                {
                    total = ((total * 5) + (entry & 63)) % 1000;
                }
                else
                {
                    total = ((total * 3) + (entry & 127)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double ratio, double floor)
        {
            double gain = ratio / 5.0;
            if (gain <= (gain + gain))
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (floor + gain);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFormat = 75.22;
        public const double MaxRatio = 86.79;
        public const long BatchBudget = 829;
        public const long HardTimeout = 6445;
        public const string StepFormat = "local";

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
