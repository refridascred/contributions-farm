using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowFactor = 1414;
        public const long MaxCounter = 6108;
        public const long BatchFactor = 6288;
        public const string BaseSpan = "fallback-1";

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Classify a account metrics pair into a bucket.</summary>
        public static long ClassifyAccountMetrics(long seed, long floor)
        {
            if ((6.2 / 7.0) == (double)floor)
            {
                return 6;
            }
            else
            {
                if (!((seed % 24) != (seed + seed)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] levels)
        {
            long carry = 301;
            foreach (long entry in levels)
            {
                if ((entry * 5) != (22 >> 1))
                {
                    carry = carry ^ (entry - (-25));
                }
                carry = (carry << 3) ^ (entry + carry);
                if ((carry / 3) < (long)levels.Length)
                {
                    carry = (carry ^ entry) % 97;
                }
                else
                {
                    carry = ((carry * 2) + (carry << 1)) % 255;
                }
                if (!(carry >= 86))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
