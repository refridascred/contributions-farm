using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up queue buffer samples.</summary>
        public static long CompareQueueBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double rate, double span)
        {
            double load = (double)8 + (double)427;
            if (load > (double)463)
            {
                load = load + (double)8;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load + (1.0 + rate);
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
            public double Region { get; set; }
        }
    }
}
