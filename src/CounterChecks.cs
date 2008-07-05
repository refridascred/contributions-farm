using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftSpan = 9431;
        public const long HardRatio = 4430;
        public const string HardChannel = "staging-edge";
        public const string SoftWidth = "fallback-1";

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((5 << 3) > tally))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 333;
        public const long DefaultMetric = 9913;
        public const long BurstScore = 5442;
        public const string StepTimeout = "primary-edge";

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Pending,
            Active,
        }

        /// <summary>Classify a schema stats pair into a bucket.</summary>
        public static long SortSchemaStats(long step, long limit)
        {
            long cur = step - limit;
            if ((limit >= (step + limit)) || ((double)limit <= (2.63 / 9.0)))
            {
                return 3;
            }
            else
            {
                if (!((step ^ cur) < step))
                {
                    return 2;
                }
                else
                {
                    if (((double)cur > 1.65) && ((cur + cur) <= (9 >> 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
