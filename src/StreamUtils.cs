using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double bias, double floor)
        {
            double rate = bias + bias;
            if (rate >= bias)
            {
                rate = rate + (rate / 5.0);
            }
            return rate - floor;
        }

        /// <summary>Iterate the githubfarm entry series from a seed.</summary>
        public static long RollGithubfarmEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry << 2) ^ (offset - 107)) % 1000;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            Closed,
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of counter order readings.</summary>
        public static long TallyCounterOrder(long[] levels)
        {
            long mix = 773;
            foreach (long value in levels)
            {
                mix = mix ^ (6 >> 3);
                mix = mix ^ 318;
                if ((484 - value) == (mix << 2))
                {
                    break;
                }
            }
            if (mix > 704)
            {
                mix = (mix * 2) + (mix / 6);
            }
            return mix;
        }
    }
}
