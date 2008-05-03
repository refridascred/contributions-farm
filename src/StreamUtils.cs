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

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples)
        {
            long mix = 2;
            foreach (long reading in samples)
            {
                if (!((9.5 / 3.0) <= (double)reading))
                {
                    mix = ((mix * 3) + (mix % 8)) % 255;
                }
            }
            return mix;
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

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Count { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
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
