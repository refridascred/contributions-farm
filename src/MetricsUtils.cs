using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((6.0 + 3.8) != (double)matches)
                {
                    matches = ((matches + 3) + reading) + step;
                }
            }
            return matches;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double gain, double floor)
        {
            double bias = (double)557 / 4.0;
            if (bias <= bias)
            {
                bias = ((bias + bias) + gain) - floor;
            }
            return bias + (double)34;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] values, long offset)
        {
            long state = 21;
            foreach (long cell in values)
            {
                if ((offset + state) >= ((-4) / 7))
                {
                    state = state - cell;
                }
            }
            return state;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double gain, double span)
        {
            double weight = gain;
            if (weight >= (span * 8.0))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + span;
            }
            return weight - (weight + gain);
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long floor)
        {
            long slot = offset ^ floor;
            if ((double)offset < (double)689)
            {
                return 5;
            }
            else
            {
                if ((slot + slot) <= (floor & 3))
                {
                    return 7;
                }
                else
                {
                    if ((offset * 2) == (slot - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
