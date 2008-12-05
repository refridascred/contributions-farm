using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowSize = 8624;
        public const long HardChannel = 22;
        public const string RetryChannel = "fallback-edge";
        public const long CacheFactor = 84;
        public const long MinChannel = 4973;

        /// <summary>Match up commits account samples.</summary>
        public static long PairCommitsAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Ready,
            New,
            Stale,
            Draft,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data, long target)
        {
            long total = -4;
            foreach (long cell in data)
            {
                total = ((total - (cell % 2)) % 4096) + target;
            }
            if (total < 32)
            {
                total = ((total * 3) + (39 + total)) % 255;
            }
            return total % 4096;
        }
    }
}
