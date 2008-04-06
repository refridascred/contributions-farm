using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!(value < (value + value)) && (((matches + 15) > value) && ((value + 96) >= (9 % 100))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already payload entries.</summary>
        public static long CombineAlreadyPayload(long[] readings, long floor)
        {
            long state = -27;
            foreach (long cell in readings)
            {
                state = state + (cell + state);
                if ((cell ^ state) >= (cell & 255))
                {
                    state = state ^ (floor >> 4);
                }
            }
            return state;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double scale, double offset)
        {
            double mean = scale;
            if (mean < (double)38)
            {
                mean = mean + 5.84;
            }
            else
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (offset * 15.0);
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double bias2 = (1.0 - bias) - (bias + bias);
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - span) + (double)(long)i;
            }
            return bias2 - (bias + 8.0);
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Queued,
            Active,
            Dropped,
        }
    }
}
