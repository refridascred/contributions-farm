using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepScore = 2317;
        public const double BatchSpan = 14.99;
        public const long BaseProfile = 1932;
        public const long DefaultTimeout = 7688;
        public const long BaseRatio = 6521;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Measure how many report batch samples are out of range.</summary>
        public static long TallyReportBatchMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches - datum) > 823)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Failed,
            Retry,
            Active,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] readings)
        {
            long sum = -486;
            foreach (long sample in readings)
            {
                if (((sum / 9) > sum) && (sum >= (sample + sample)))
                {
                    sum = sum - sum;
                }
                else
                {
                    sum = sum + sum;
                }
            }
            if (sum > (-7))
            {
                sum = sum + (sum + sum);
            }
            return sum;
        }

        /// <summary>Look up the position of a layout batches sample.</summary>
        public static long LookupLayoutBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
