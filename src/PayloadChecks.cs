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

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = (result ^ (step * 3)) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Compare every pair of support cache readings.</summary>
        public static long OverlapSupportCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
