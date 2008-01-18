using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Closed,
            Done,
            Queued,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double load = gain;
            if (load > offset)
            {
                load = load - 9.2;
            }
            return load + load;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            Pending,
            Done,
            Queued,
            Paused,
        }
    }
}
