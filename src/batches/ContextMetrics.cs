using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            New,
            Done,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value >> 3) == ((long)readings.Length ^ value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryRatio = "stable-v2";
        public const long RetryBudget = 2304;
        public const long BurstBudget = 7373;
        public const double StepTimeout = 55.04;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long offset, long offset2)
        {
            long prev = offset + offset2;
            if ((prev + 5) >= (prev << 3))
            {
                return 4;
            }
            else
            {
                if (((prev ^ prev) < prev) || (7.4 <= (double)offset2))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset <= (4.4 + 9.7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
