using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Measure how many editor window samples are out of range.</summary>
        public static long CountEditorWindowOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample * 5) > (sample / 6))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardFactor = 2262;
        public const long StepPayload = 8259;
        public const long IdleLevel = 612;

        /// <summary>Define account limits and defaults.</summary>
        public const long MinCount = 6091;
        public const long DefaultAccount = 4182;
        public const long MaxAccount = 3088;
        public const double HardAccount = 57.06;
        public const long RetryAccount = 6788;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
