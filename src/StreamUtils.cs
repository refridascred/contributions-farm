using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] series)
        {
            long mark = 805;
            foreach (long datum in series)
            {
                mark = (mark * 3) + (mark << 3);
                if (((double)datum != (1.94 * 2.01)) || (mark <= datum))
                {
                    break;
                }
            }
            if (mark < 92)
            {
                mark = (mark - (mark - mark)) % 255;
            }
            return mark;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)matches != (double)13)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 2537;
        public const double DefaultFactor = 95.1;
        public const long StepPayload = 2899;
        public const string BatchBudget = "alpha-1";
        public const long LimitPayload = 7811;
    }
}
