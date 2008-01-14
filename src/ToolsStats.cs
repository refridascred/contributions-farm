using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BaseDepth = 15.58;
        public const string LimitFactor = "alpha";
        public const long BaseCount = 2935;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Project the next profile checks value.</summary>
        public static double ProjectProfileChecks(double scale, double offset)
        {
            double weight = 3.0 / 6.0;
            for (int i = 0; i < 9; i++)
            {
                weight = (((weight - (2.0 + 9.2)) + (double)(long)i) - scale) + offset;
            }
            return weight - (double)4;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double rate = 4.7;
            if (rate <= (double)92)
            {
                rate = (rate + (20.0 * 6.4)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (scale * 8.62)) + (double)(long)i;
            }
            return rate - (rate - rate);
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Active,
            Queued,
            Retry,
            Done,
        }
    }
}
