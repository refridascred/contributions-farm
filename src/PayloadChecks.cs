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

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitRatio = 12.16;
        public const double DefaultWindow = 19.74;
        public const double BurstWidth = 11.98;
        public const long StepInterval = 3074;
        public const long BatchScore = 8153;

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

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
