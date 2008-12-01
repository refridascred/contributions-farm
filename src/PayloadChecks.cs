using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally + datum) >= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitRatio = 12.16;
        public const double DefaultWindow = 19.74;
        public const double BurstWidth = 11.98;
        public const long StepInterval = 3074;
        public const long BatchScore = 8153;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseRatio = 4653;
        public const long SoftDepth = 3320;
        public const long BurstSpan = 5188;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long offset, long bound)
        {
            long slot = offset - bound;
            if ((double)slot > (1.0 - 9.23))
            {
                return 3;
            }
            else
            {
                if ((bound + bound) != (offset >> 1))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
            public double Level { get; set; }
        }
    }
}
