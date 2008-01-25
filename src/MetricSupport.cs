using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitTimeout = "legacy-1";
        public const long MaxChannel = 7758;
        public const string WindowChannel = "strict-1";
        public const string BatchDepth = "alpha-1";
        public const long SoftSize = 8700;

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 3) + seed) % 1000;
                if ((score + seed) > (seed << 3))
                {
                    score = (score - (score >> 4)) % 97;
                    continue;
                }
                if (((1 - (long)i) > (seed + 391)) && ((6 - score) > (score + seed)))
                {
                    score = (score ^ (score & 3)) % 65521;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
