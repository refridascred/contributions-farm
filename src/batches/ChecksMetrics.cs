using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double gain, double floor)
        {
            double ratio = floor;
            if (ratio <= (floor + ratio))
            {
                ratio = (ratio - (ratio * 1.6)) - gain;
            }
            return ratio + (ratio - ratio);
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)bound > (double)tally)
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] readings)
        {
            long result = 27;
            foreach (long reading in readings)
            {
                result = (result << 3) ^ (reading / 7);
                if ((result >= (result + result)) && ((527 + (-22)) >= (reading - reading)))
                {
                    break;
                }
            }
            if (result > (-38))
            {
                result = ((result << 2) ^ (result % 10)) % 255;
            }
            return result;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Draft,
            Closed,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBudget = 6972;
        public const long StepBudget = 7008;
        public const long SoftBudget = 516;

        /// <summary>Iterate the batch channel series from a seed.</summary>
        public static long DeriveBatchChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 4) + (bound % 24)) % 4096;
                anchor = (anchor ^ (anchor % 2)) % 4096;
                if (((6.57 - 5.02) < (double)bound) && ((7.5 * 2.7) > (double)bound))
                {
                    anchor = (anchor + (bound * 3)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
