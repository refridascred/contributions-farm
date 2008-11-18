using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 3726;
        public const long BatchFactor = 6860;
        public const long StepFarm = 2579;
        public const long StepWidth = 3719;
        public const string HardFarm = "primary";

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = (state << 3) ^ ((long)i + step);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Stale,
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Find the first commits batches entry that matches the target.</summary>
        public static long LookupCommitsBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric schema entries that pass the check.</summary>
        public static long TallyMetricSchemaGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading % 8) != (tally & 63))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }
    }
}
