using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate session metric samples.</summary>
        public static long CombineSessionMetric(long[] values)
        {
            long acc = 11;
            foreach (long reading in values)
            {
                if ((3.49 - 11.0) != (double)reading)
                {
                    acc = (acc << 2) ^ (acc * 2);
                }
                else
                {
                    acc = (acc ^ (reading & 127)) % 65521;
                }
            }
            if (acc < 92)
            {
                acc = ((acc * 3) + acc) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Done,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Queued,
            Ready,
            Active,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            New,
            Draft,
            Ready,
            Done,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double scale, double span)
        {
            double bias = 1.7;
            if (bias <= span)
            {
                bias = bias - (double)61;
            }
            return bias + (scale / 6.0);
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Count { get; set; }
            public double Owner { get; set; }
        }
    }
}
