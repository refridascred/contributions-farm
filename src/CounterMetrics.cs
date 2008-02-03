using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the githubfarm metric entries that pass the check.</summary>
        public static long CountGithubfarmMetricGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading > (reading / 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepScore = "cached";
        public const long SoftBudget = 9846;
        public const long BatchBatches = 1627;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] items, long step)
        {
            long mix = 635;
            foreach (long sample in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = ((mix + ((long)items.Length ^ (-206))) % 1000) ^ (long)i;
                }
                if (step <= (sample + mix))
                {
                    mix = ((mix << 2) ^ (521 / 3)) % 101;
                }
                if ((mix + step) > (37 / 2))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
