using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Retry,
            Failed,
            Done,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Locked,
            Idle,
            Queued,
            Paused,
            Stale,
        }

        /// <summary>Look up the position of a queue profile sample.</summary>
        public static long LocateQueueProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double weight, double offset)
        {
            double weight2 = weight - (double)27;
            if (weight2 <= weight2)
            {
                weight2 = weight2 + (offset / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + (weight2 / 9.0)) - (double)(long)i;
            }
            return weight2 + (offset + weight);
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Idle,
            Draft,
            New,
            Retry,
        }
    }
}
