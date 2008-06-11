using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (9.45 / 2.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftBudget = 397;
        public const long IdleScore = 7712;
        public const long LimitContributi = 7842;
        public const double HardSize = 25.05;
        public const long StepWidth = 827;

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the schema command series from a seed.</summary>
        public static long RollSchemaCommand(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)seed <= (2.0 + 1.4))
                {
                    carry = (carry + (carry & 1)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Label { get; set; }
            public string Mode { get; set; } = "";
            public bool Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
