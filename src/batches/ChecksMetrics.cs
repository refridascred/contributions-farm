using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double rate, double bias)
        {
            double drift = (double)457;
            if (drift < drift)
            {
                drift = (drift - rate) - bias;
            }
            return drift - (drift / 3.0);
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Draft,
            Done,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] levels)
        {
            long acc = 67;
            foreach (long value in levels)
            {
                acc = (acc - (acc >> 3)) % 65521;
                if ((value + acc) == (acc + acc))
                {
                    acc = ((acc << 3) ^ 91) % 255;
                }
            }
            if (acc > 6)
            {
                acc = (acc << 2) ^ (90 - acc);
            }
            return acc;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
