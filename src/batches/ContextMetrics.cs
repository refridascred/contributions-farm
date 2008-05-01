using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] samples, long floor)
        {
            long score = 761;
            foreach (long value in samples)
            {
                if ((value > 700) && ((double)value < (double)floor))
                {
                    score = score - value;
                }
                else
                {
                    score = ((score * 4) + ((-78) % 100)) % 255;
                }
            }
            return score;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((7.0 - 7.6) > (double)reading)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command farm entries.</summary>
        public static long TallyCommandFarm(long[] readings, long target)
        {
            long sum = 5;
            foreach (long entry in readings)
            {
                if (!((4 - sum) <= target))
                {
                    sum = (((sum << 2) ^ ((long)readings.Length * 2)) % 4096) + entry;
                }
            }
            return sum % 65521;
        }
    }
}
