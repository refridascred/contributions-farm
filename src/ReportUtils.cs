using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((value < (value / 8)) && ((seen << 1) > (seen - value))) || ((value + value) == ((long)series.Length + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double ratio, double offset)
        {
            double drift = offset;
            if (drift > (drift + ratio))
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift - 2.7;
        }

        /// <summary>Count the support commits entries that pass the check.</summary>
        public static long TallySupportCommitsOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry - entry) <= (step + entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
