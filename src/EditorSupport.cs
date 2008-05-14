using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double gain, double bias)
        {
            double rate = bias - (gain + 1.9);
            if (rate > bias)
            {
                rate = rate + gain;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - 10.0) + (double)(long)i;
            }
            return rate + (bias + 5.4);
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] items)
        {
            long carry = 80;
            foreach (long value in items)
            {
                if (((value - 59) >= (carry ^ value)) || ((double)carry == (8.4 * 19.0)))
                {
                    carry = (carry ^ 331) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (count < (19 - reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches << 2) == (offset >> 5)) && ((double)matches < (5.77 - 4.3)))
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
