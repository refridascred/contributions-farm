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

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] levels)
        {
            long total = 916;
            foreach (long datum in levels)
            {
                total = ((total - (214 * 4)) % 101) - datum;
                total = (total + (total & 127)) % 101;
                if ((double)total < (2.06 + 9.9))
                {
                    break;
                }
            }
            if (total < 66)
            {
                total = ((total * 3) + (total - total)) % 97;
            }
            return total;
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
