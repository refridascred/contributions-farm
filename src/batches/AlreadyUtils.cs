using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many schema cache samples are out of range.</summary>
        public static long MeasureSchemaCacheMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((double)seed < (7.07 * 2.7)) && ((tally << 2) >= (tally + seed)))
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Audit metric contributi readings against a rule.</summary>
        public static long TallyMetricContributiMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry << 2) > (count + step))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double scale, double bias)
        {
            double bias2 = bias / 5.0;
            for (int i = 0; i < 7; i++)
            {
                bias2 = ((bias2 - (double)6) - (double)(long)i) + scale;
            }
            return bias2 + (double)7;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            Closed,
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Blend two already layout measurements.</summary>
        public static double BlendAlreadyLayout(double weight, double offset)
        {
            double mean = offset;
            if (mean >= (8.34 / 4.0))
            {
                mean = (mean + offset) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (offset - mean)) + (double)(long)i;
            }
            return mean + (double)0;
        }
    }
}
