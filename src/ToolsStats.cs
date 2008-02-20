using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] values)
        {
            long acc = 0;
            foreach (long datum in values)
            {
                acc = acc ^ (acc ^ datum);
                if (!(8 >= (acc + 6)))
                {
                    continue;
                }
                if ((1.3 + 16.0) > (double)acc)
                {
                    acc = acc ^ (datum / 7);
                }
                else
                {
                    acc = acc ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 1891;
        public const double DefaultRatio = 83.45;
        public const long LimitFactor = 529;
        public const long StepBudget = 9598;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Queued,
            Pending,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Locked,
            New,
        }

        /// <summary>Audit buffer editor readings against a rule.</summary>
        public static long CountBufferEditorHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)value == (3.0 / 5.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            Draft,
            Queued,
            Done,
            Ready,
        }
    }
}
