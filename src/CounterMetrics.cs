using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long step, long origin)
        {
            long span = step ^ origin;
            if ((double)span <= 1.82)
            {
                return 1;
            }
            else
            {
                if (((908 & 3) != (span >> 1)) || ((step & 7) > (33 + step)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepScore = 2505;
        public const long BaseBudget = 4948;
        public const long CacheAlready = 3778;
        public const long BatchAlready = 1602;
        public const long MinSize = 1577;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((((sample + tally) >= (long)samples.Length) && ((double)812 != (double)tally)) && ((tally <= sample) || ((sample * 3) < (sample + tally))))
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
    }
}
