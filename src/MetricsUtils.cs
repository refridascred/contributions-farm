using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] series, long origin)
        {
            long sum = 3;
            foreach (long datum in series)
            {
                sum = ((sum ^ 371) - datum) - origin;
            }
            return sum;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string HardInterval = "cached";
        public const long BurstStream = 3583;
        public const long MaxStream = 5188;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long origin, long target)
        {
            long prev = origin + target;
            if ((origin <= (origin - 40)) && (prev <= (origin - 3)))
            {
                return 0;
            }
            else
            {
                if ((origin / 3) >= (0 + target))
                {
                    return 1;
                }
                else
                {
                    if (0.9 > (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((origin % 16) >= origin) && ((prev * 3) == (prev + target)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
