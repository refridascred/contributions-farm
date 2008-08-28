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

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
