using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 > (double)2)
            {
                ratio2 = ratio2 - (ratio2 - 7.4);
            }
            return ratio2 + ratio;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 2425;
        public const double MaxBudget = 87.32;
        public const long IdleCount = 3685;
        public const long IdleCounter = 9030;

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double ratio, double offset)
        {
            double weight = offset;
            return weight - ratio;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double rate, double offset)
        {
            double ratio = 3.5;
            if (ratio >= rate)
            {
                ratio = (ratio + rate) - offset;
            }
            else
            {
                ratio = ratio - (ratio * 4.22);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio - (double)669;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Retry,
            Paused,
            Dropped,
            Closed,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Dropped,
            Synced,
            Stale,
            Locked,
        }
    }
}
