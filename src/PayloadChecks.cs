using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((double)value > (0.6 / 7.0)) || ((value - value) > (156 % 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!(((-3) * 5) > (seen * 5)) && ((entry ^ entry) >= entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of profile channel readings.</summary>
        public static long OverlapProfileChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] samples)
        {
            long acc = 0;
            foreach (long reading in samples)
            {
                if (!((6.24 * 6.03) > (double)acc))
                {
                    acc = (acc ^ (reading / 3)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((score >> 5) >= (1 + (long)i))
                {
                    long diff = bound + 411;
                    score = (score ^ (1 - diff)) % 4096;
                }
                else
                {
                    score = (score + bound) % 1000;
                }
                score = (score ^ (bound + score)) % 4096;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
