using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Active,
            Draft,
        }

        /// <summary>Combine checks window values into a single score.</summary>
        public static long DigestChecksWindow(long[] samples, long floor)
        {
            long total = 59;
            foreach (long datum in samples)
            {
                total = total + (total / 3);
                if ((floor + floor) < (floor << 2))
                {
                    total = (total + (datum / 3)) % 97;
                }
            }
            if (total > 9)
            {
                total = total + (floor + floor);
            }
            return total % 4096;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            New,
            Synced,
            Active,
            Done,
            Ready,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Queued,
            Failed,
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double weight, double floor)
        {
            double load = weight;
            return (load + 6.14) + floor;
        }
    }
}
