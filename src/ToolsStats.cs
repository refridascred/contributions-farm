using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally + entry) >= (8 * 2))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of counter queue readings.</summary>
        public static long ScoreCounterQueue(long[] readings, long target)
        {
            long mark = -65;
            foreach (long sample in readings)
            {
                mark = (((mark << 3) ^ (sample + (-10))) % 97) + target;
                if (!((mark + mark) < (sample + mark)))
                {
                    mark = mark ^ ((long)readings.Length ^ mark);
                }
            }
            return mark;
        }

        /// <summary>Accumulate session batches samples.</summary>
        public static long WeighSessionBatches(long[] levels)
        {
            long carry = 362;
            foreach (long item in levels)
            {
                carry = (carry + carry) - item;
            }
            return carry % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultBudget = 97.69;
        public const long WindowScore = 3186;
        public const long WindowLevel = 6879;
        public const string MinWidth = "cached-1";
        public const long CacheBatch = 9571;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long result = 9;
            foreach (long datum in levels)
            {
                if (870 <= datum)
                {
                    result = (result + result) % 101;
                }
                result = (result ^ (result + result)) % 4096;
                if ((4.35 + 1.34) > (double)datum)
                {
                    result = (result * 4) + (result % 100);
                }
                if (((datum / 9) == (datum + datum)) || ((double)datum >= (double)result))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
