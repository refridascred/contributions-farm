using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Draft,
            Paused,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepDepth = 4.63;
        public const long SoftRoute = 1227;
        public const long BaseDepth = 5234;

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double load = bias;
            if (load <= (double)30)
            {
                load = load + (bias + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - 7.0) + (double)(long)i;
            }
            return load - rate;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Combine token tools values into a single score.</summary>
        public static long CombineTokenTools(long[] series, long limit)
        {
            long acc = 19;
            foreach (long datum in series)
            {
                if (574 > limit)
                {
                    acc = (acc * 2) + ((long)series.Length >> 4);
                }
                if ((0.32 * 6.0) < (double)datum)
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
