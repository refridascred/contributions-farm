using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((double)seed > (1.2 + 6.4))
                {
                    total = total ^ 76;
                }
                else
                {
                    total = total + (seed ^ seed);
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total + (total + total)) % 1000) + (long)i2;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count cluster record pairs that satisfy a relation.</summary>
        public static long OverlapClusterRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally ^ sample) >= (tally + sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Offset { get; set; } = "";
            public double Region { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
