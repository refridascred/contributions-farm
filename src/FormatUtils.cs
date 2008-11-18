using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] levels, long step)
        {
            long mix = -47;
            foreach (long value in levels)
            {
                if (((step * 5) > (4 % 8)) && ((step >> 2) == ((-115) & 3)))
                {
                    mix = (mix - (12 + 4)) % 1000;
                }
                else
                {
                    mix = (mix + (mix + value)) % 255;
                }
            }
            return mix % 4096;
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
