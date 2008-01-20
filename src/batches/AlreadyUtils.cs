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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long step, long offset)
        {
            if ((step & 1) < (step >> 5))
            {
                return 2;
            }
            else
            {
                if (offset < (offset >> 4))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
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
