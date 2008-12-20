using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "cached-edge";
        public const double WindowSize = 64.86;
        public const double BurstRatio = 97.44;

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next schema checks value from a seed.</summary>
        public static long IterateSchemaChecks(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 2) ^ score) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Failed,
            Closed,
            New,
        }
    }
}
