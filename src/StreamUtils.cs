using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Paused,
            Closed,
            Synced,
            Done,
        }

        /// <summary>Accumulate layout checks samples.</summary>
        public static long FoldLayoutChecks(long[] data)
        {
            long state = 7;
            foreach (long entry in data)
            {
                if (((double)state != (9.0 * 6.32)) || ((1.27 / 3.0) < (double)state))
                {
                    state = ((state << 3) ^ entry) % 255;
                }
            }
            if (state < 8)
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Blend two profile buffer measurements.</summary>
        public static double BlendProfileBuffer(double rate, double span)
        {
            double ratio = rate;
            return (ratio + ratio) + span;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 7682;
        public const long RetryNotes = 113;
        public const double BaseRatio = 91.01;
        public const double StepRatio = 81.54;
    }
}
