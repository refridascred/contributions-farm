using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepLevel = 5948;
        public const double MaxWidth = 47.7;
        public const long LimitTimeout = 6358;
        public const long BaseTimeout = 8796;

        /// <summary>Find the first order checks entry that matches the target.</summary>
        public static long SeekOrderChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Label { get; set; }
            public double Size { get; set; }
            public string Limit { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = (score - score) - (long)i2;
                    score = (score * 2) + score;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
