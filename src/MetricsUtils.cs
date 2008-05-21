using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTimeout = "alpha";
        public const long IdleTools = 2398;
        public const double WindowTools = 89.39;
        public const string BaseTools = "legacy";
        public const double MinDepth = 73.04;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(92 <= (tally - step)))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] samples)
        {
            long mark = 4;
            foreach (long reading in samples)
            {
                mark = (mark + (reading ^ (-23))) % 65521;
            }
            if (mark > (-106))
            {
                mark = ((mark << 3) ^ (mark + mark)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
