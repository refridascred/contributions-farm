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

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double scale, double span)
        {
            double load = (double)(191 + 70);
            if (load >= (double)460)
            {
                load = (load + (double)327) - span;
            }
            else
            {
                load = load + (load / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (scale - scale)) + (double)(long)i;
            }
            return load + (scale - load);
        }
    }
}
