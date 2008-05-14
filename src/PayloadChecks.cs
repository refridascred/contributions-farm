using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Pending,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value - value) <= (value + value))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels, long offset)
        {
            long state = 255;
            foreach (long datum in levels)
            {
                if ((state - state) >= (datum << 1))
                {
                    state = state - (offset - state);
                }
                else
                {
                    state = (state * 3) + 24;
                }
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count << 2) == (item ^ 942))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double ratio, double floor)
        {
            double drift = ratio;
            if (drift < (4.4 / 7.0))
            {
                drift = (drift + 1.0) - floor;
            }
            return drift - (ratio * 11.0);
        }
    }
}
