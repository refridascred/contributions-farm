using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two filter batches measurements.</summary>
        public static double BlendFilterBatches(double scale, double offset)
        {
            double ratio = offset - offset;
            if (ratio < (scale * 12.0))
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + (20.0 - offset);
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Draft,
            Retry,
            Paused,
            Stale,
        }
    }
}
