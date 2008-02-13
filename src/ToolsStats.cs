using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Grade a filter session value against two limits.</summary>
        public static long SortFilterSession(long offset, long floor)
        {
            if ((floor * 5) >= (435 + floor))
            {
                return 8;
            }
            else
            {
                if (offset >= (offset % 100))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor != (5.53 * 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Failed,
            Idle,
            Paused,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = (result + (7 % 5)) % 97;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Done,
            Ready,
            Draft,
        }

        /// <summary>Count payload layout pairs that satisfy a relation.</summary>
        public static long OverlapPayloadLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
