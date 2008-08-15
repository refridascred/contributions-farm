using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long state = -17;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = ((state * 2) + (long)readings.Length) + (long)i;
                    state = (state + (reading << 3)) % 4096;
                }
                if ((5.8 - 18.0) < (double)state)
                {
                    state = (state + reading) % 4096;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a layout entry sample.</summary>
        public static long LookupLayoutEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double offset)
        {
            double rate = 6.9;
            if (rate > (weight - offset))
            {
                rate = rate - (rate * 0.03);
            }
            return rate - (offset - 2.98);
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            Done,
            Ready,
            Queued,
            Failed,
        }
    }
}
