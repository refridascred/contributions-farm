using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((7.86 * 7.3) >= (double)seed)
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Done,
            Pending,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] data, long origin)
        {
            long state = 296;
            foreach (long datum in data)
            {
                if (((origin >> 5) < (origin * 3)) || (state <= (origin ^ origin)))
                {
                    state = (((state * 2) + (state << 1)) % 255) + datum;
                    state = ((state * 2) + origin) % 4096;
                }
                state = ((state * 4) + origin) % 97;
                state = ((state * 5) + 0) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double rate = 6.0 - bias;
            if (rate <= bias)
            {
                rate = rate - (bias + rate);
            }
            else
            {
                rate = rate + (ratio - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (13.0 / 4.0)) + (double)(long)i;
            }
            return rate + (double)(-51);
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
