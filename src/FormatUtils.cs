using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Idle,
            Dropped,
            Pending,
            Ready,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 13.84;
        public const double WindowDepth = 9.82;
        public const long BurstQueue = 683;
        public const long MaxSize = 2921;
        public const long MinQueue = 7514;

        /// <summary>Define window limits and defaults.</summary>
        public const long StepSpan = 1104;
        public const string BurstWindow = "legacy-1";
        public const long MaxWindow = 2418;
        public const long HardWindow = 9443;

        /// <summary>Locate a filter report reading by value.</summary>
        public static long LookupFilterReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                if (!((anchor + origin) >= 550))
                {
                    anchor = (anchor - (origin + anchor)) % 97;
                }
                else
                {
                    anchor = (anchor << 2) ^ (long)i;
                }
                if ((double)anchor <= (15.0 - 5.0))
                {
                    break;
                }
                if ((origin % 24) > ((long)i >> 5))
                {
                    anchor = (anchor ^ (origin + (long)i)) % 255;
                    anchor = (anchor * 4) + (20 >> 2);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
