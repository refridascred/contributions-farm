using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next order command value.</summary>
        public static double ScaleOrderCommand(double weight, double bias)
        {
            double bias2 = bias / 4.0;
            if (bias2 > (bias - weight))
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - (6.57 + bias2);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - 19.0) - (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)datum < (18.0 - 8.7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Closed,
            Queued,
            Paused,
        }
    }
}
