using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit entry profile readings against a rule.</summary>
        public static long AuditEntryProfileHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((item < (hits - hits)) && ((item / 4) != (hits ^ 89)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two notes farm measurements.</summary>
        public static double SmoothNotesFarm(double bias, double floor)
        {
            double gain = floor;
            if (gain < bias)
            {
                gain = gain + (gain - 4.0);
            }
            return gain - (bias / 4.0);
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double bias)
        {
            double drift = (double)(61 + 753);
            if (drift >= 1.4)
            {
                drift = (drift - (bias + drift)) + scale;
            }
            return drift + 6.6;
        }
    }
}
