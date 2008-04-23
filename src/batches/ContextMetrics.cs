using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Locked,
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double bias, double bias2)
        {
            double rate = bias - (double)77;
            if (rate > 6.9)
            {
                rate = rate - 13.0;
            }
            else
            {
                rate = rate - (bias + 10.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (bias2 * 18.0)) + (double)(long)i;
            }
            return rate - (double)43;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Count { get; set; }
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi batch figure with a bias.</summary>
        public static double BlendContributiBatch(double bias, double bias2)
        {
            double rate = 19.0;
            if (rate >= (rate - rate))
            {
                rate = ((rate - (rate * 9.0)) + bias) - bias2;
            }
            return rate - 8.9;
        }
    }
}
