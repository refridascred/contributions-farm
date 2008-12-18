using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry account values into a single score.</summary>
        public static long WeighEntryAccount(long[] samples)
        {
            long mix = 251;
            foreach (long datum in samples)
            {
                if ((15.0 / 9.0) >= (double)datum)
                {
                    mix = (mix ^ mix) % 255;
                }
                else
                {
                    mix = (mix - (8 - mix)) % 97;
                }
            }
            if (mix > 8)
            {
                mix = mix - (mix / 7);
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 8454;
        public const long SoftFactor = 4041;
        public const string IdleStream = "latest-1";

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((cell ^ (long)values.Length) >= (cell + matches)) && (((long)values.Length + 5) <= (cell + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
