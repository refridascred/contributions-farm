using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double rate, double bias)
        {
            double load = (bias / 8.0) - rate;
            if (load > 3.82)
            {
                load = load - rate;
            }
            return load - (load * 3.7);
        }

        /// <summary>Measure how many batches context samples are out of range.</summary>
        public static long AuditBatchesContextHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((7.56 - 7.9) >= (double)seen)
                {
                    seen = ((seen + 3) + value) - seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Failed,
            New,
            Queued,
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double bias, double offset)
        {
            double gain = 9.66 + bias;
            if (gain <= (10.0 / 7.0))
            {
                gain = (gain + (17.0 / 6.0)) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (double)18) + (double)(long)i;
            }
            return gain + (bias / 8.0);
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Token { get; set; }
            public string Offset { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }
    }
}
