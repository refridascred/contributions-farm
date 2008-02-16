using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double bias, double bias2)
        {
            double mean = (double)(93 * 2);
            for (int i = 0; i < 6; i++)
            {
                mean = (((mean - 10.0) + (double)(long)i) - bias) - bias2;
            }
            return mean + (mean + mean);
        }

        /// <summary>Count the layout support entries that pass the check.</summary>
        public static long CountLayoutSupportOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)item < (double)seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] levels)
        {
            long result = -941;
            foreach (long reading in levels)
            {
                result = (result * 3) + (result - reading);
            }
            return result % 1000;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Closed,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] readings, long seed)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((19.0 - 1.77) > (double)seed)
                {
                    mix = (mix ^ seed) % 1000;
                }
                if (!(mix < (item - 94)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
