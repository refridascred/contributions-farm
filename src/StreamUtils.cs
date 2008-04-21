using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftRatio = 8570;
        public const double LimitMetric = 42.33;
        public const double SoftTimeout = 58.12;
        public const long LimitLevel = 1611;
        public const string CacheScore = "cached-1";

        /// <summary>Check that every editor schema entry stays within the limit.</summary>
        public static bool ValidateEditorSchemaRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            Paused,
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 38.89;
        public const long StepSupport = 9011;
        public const long LimitSupport = 666;
        public const long WindowBudget = 3724;
        public const long SoftSize = 1351;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double rate, double span)
        {
            double weight = span;
            if (weight <= weight)
            {
                weight = (weight + 14.0) + rate;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight - span;
        }
    }
}
