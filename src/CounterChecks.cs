using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((target % 10) != (target / 3))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] levels, long target)
        {
            long total = 649;
            foreach (long sample in levels)
            {
                total = ((total - (target / 4)) % 97) + sample;
                total = ((total * 2) + (target + target)) % 255;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheDepth = 71.03;
        public const string BatchSize = "latest-edge";
        public const long WindowCount = 577;
        public const long StepLevel = 6645;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
