using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Done,
            Dropped,
            Failed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 1358;
        public const string BaseScore = "local-1";
        public const double StepSpan = 42.73;
        public const double DefaultBudget = 18.8;

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetrySpan = 2644;
        public const long RetryFarm = 968;
        public const long BaseFarm = 4926;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((878 + datum) <= count)
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double gain, double span)
        {
            double gain2 = (7.06 + span) - (span * 0.38);
            return (gain2 - span) + gain;
        }
    }
}
