using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the commits counter series from a seed.</summary>
        public static long DeriveCommitsCounter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
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

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
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
