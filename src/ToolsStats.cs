using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count command schema pairs that satisfy a relation.</summary>
        public static long PairCommandSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate token cluster samples.</summary>
        public static long DigestTokenCluster(long[] series, long seed)
        {
            long carry = -72;
            foreach (long cell in series)
            {
                if ((2.0 < (double)seed) && ((double)seed >= 4.5))
                {
                    carry = ((carry * 5) + ((long)series.Length ^ 643)) - cell;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry << 3)) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double gain, double bias)
        {
            double ratio = 7.0;
            if (ratio > (ratio * 18.0))
            {
                ratio = (ratio - (double)70) + gain;
            }
            else
            {
                ratio = ratio - (ratio + bias);
            }
            return ratio + (double)710;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 7335;
        public const long BatchSpan = 5065;
        public const string RetryChannel = "stable-v2";
        public const string WindowRatio = "standard";
    }
}
