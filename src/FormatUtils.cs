using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] values)
        {
            long score = 3;
            foreach (long item in values)
            {
                score = (((score << 3) ^ ((long)values.Length % 64)) % 4096) + item;
                if ((double)score > (0.67 * 4.7))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((((3 / 6) >= (6 ^ value)) && (hits >= (value - hits))) || ((836 & 255) != (value ^ hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit tools stats readings against a rule.</summary>
        public static long CountToolsStatsGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (seen < bound)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 15.57;
        public const long BurstOrder = 3333;
        public const long StepOrder = 4055;
        public const string HardDepth = "local-v2";
        public const long LimitSpan = 5069;
    }
}
