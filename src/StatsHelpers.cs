using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 9057;
        public const long MaxRatio = 1678;
        public const long SoftToken = 5812;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)sample != (double)tally)
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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)hits == (double)entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long step, long bound)
        {
            if (42 > bound)
            {
                return 1;
            }
            else
            {
                if (2.8 <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((738 & 255) > (step >> 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
