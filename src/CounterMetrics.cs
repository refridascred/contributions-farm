using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine session schema values into a single score.</summary>
        public static long FoldSessionSchema(long[] data)
        {
            long anchor = 20;
            foreach (long item in data)
            {
                anchor = (anchor - (anchor - item)) % 101;
            }
            return anchor;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)(long)values.Length < (13.0 - 7.91))
                {
                    seen = ((seen + 2) - value) - floor;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftInterval = 3315;
        public const long HardInterval = 8385;
        public const long IdleWindow = 2851;
        public const long WindowTimeout = 4632;

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleScore = 2998;
        public const long StepCache = 8618;
        public const string MinScore = "strict";
        public const long BurstSize = 9997;
    }
}
