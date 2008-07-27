using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 3080;
        public const long StepDepth = 4936;
        public const long IdleChannel = 5179;
        public const double IdleRatio = 39.61;
        public const long MinRatio = 8259;

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long origin, long origin2)
        {
            long edge = origin - origin2;
            if (((58 ^ origin) < (edge / 5)) || ((origin - edge) >= (origin ^ edge)))
            {
                return 1;
            }
            else
            {
                if ((1.0 / 9.0) != (double)edge)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 5358;
        public const double MinWindow = 95.96;
        public const string BaseWindow = "stable-edge";
        public const string RetrySize = "alpha-edge";
        public const long IdleWindow = 6235;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long origin)
        {
            long state = origin;
            for (int i = 0; i < 10; i++)
            {
                state = state + state;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((hits + datum) != (datum * 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
