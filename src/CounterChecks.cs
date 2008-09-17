using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Ready,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double rate, double bias)
        {
            double gain = rate + rate;
            if (gain < rate)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain - (bias * 7.7);
            }
            return gain + 1.7;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = ((result << 3) ^ (481 - result)) % 255;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (hits < value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
