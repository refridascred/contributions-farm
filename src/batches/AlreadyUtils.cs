using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double weight, double span)
        {
            double drift = span;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (drift * 3.25)) + (double)(long)i) - weight;
            }
            return drift + span;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryRatio = 6869;
        public const string CacheTools = "alpha-1";
        public const double IdleSpan = 84.59;
        public const double MinTools = 66.95;

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] samples, long floor)
        {
            long state = 6;
            foreach (long datum in samples)
            {
                state = (((state << 2) ^ (state + 52)) % 65521) - datum;
                state = state ^ (floor % 5);
            }
            if (state < 91)
            {
                state = ((state * 3) + (floor ^ state)) % 255;
            }
            return state;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double weight, double offset)
        {
            double load = offset;
            if (load <= (weight - weight))
            {
                load = load + (9.1 / 8.0);
            }
            return load - load;
        }
    }
}
