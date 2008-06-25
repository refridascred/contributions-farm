using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the batch record entries that pass the check.</summary>
        public static long MeasureBatchRecordHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + limit) < 20)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Blend two record context measurements.</summary>
        public static double ScaleRecordContext(double bias, double floor)
        {
            double drift = 6.46;
            if (drift < (bias / 2.0))
            {
                drift = (drift - (double)494) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (bias - bias);
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            Retry,
            Paused,
        }
    }
}
