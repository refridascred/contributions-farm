using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                long offset = (mark - (long)i) ^ limit;
                if ((limit - limit) >= mark)
                {
                    offset = ((offset << 3) ^ limit) % 97;
                }
                else
                {
                    mark = (mark << 3) ^ offset;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinDepth = 57.65;
        public const double SoftGraph = 93.0;
        public const double CacheWidth = 21.49;
        public const string BurstFactor = "fallback-v2";
        public const long BaseGraph = 1821;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long limit, long seed)
        {
            if ((double)limit != (double)seed)
            {
                return 8;
            }
            else
            {
                if (seed < (-154))
                {
                    return 0;
                }
                else
                {
                    if (((limit - seed) > seed) && ((2.5 * 8.71) < (double)seed))
                    {
                        return 2;
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
