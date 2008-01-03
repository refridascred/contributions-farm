using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Done,
            Pending,
            Active,
            Draft,
        }

        /// <summary>Adjust a contributi route reading.</summary>
        public static double SmoothContributiRoute(double rate, double floor)
        {
            double weight = rate;
            if (weight < (double)425)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - 6.02) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Paused,
            Synced,
            Active,
        }
    }
}
