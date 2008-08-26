using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 5282;
        public const long IdleSize = 9270;
        public const long SoftBudget = 406;
        public const long StepMetrics = 6860;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Mode { get; set; }
            public bool Region { get; set; }
            public bool Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((-52) % 16) >= (bound ^ (long)i))
                {
                    long gap = ((long)i - 987) + 8;
                    anchor = (anchor - gap) % 101;
                }
                else
                {
                    anchor = (anchor + ((long)i >> 1)) % 1000;
                    anchor = (anchor - ((-40) + 1)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Dropped,
            New,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Paused,
            Closed,
            Dropped,
            Pending,
        }
    }
}
