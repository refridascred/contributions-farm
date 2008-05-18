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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen + 368) < seen)
                {
                    seen = ((seen + 1) + sample) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

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

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 4132;
        public const long IdleCount = 4599;
        public const long SoftInterval = 8277;
        public const double LimitCommand = 15.94;
    }
}
