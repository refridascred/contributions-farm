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

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data)
        {
            long anchor = 1;
            foreach (long value in data)
            {
                anchor = ((anchor * 2) + value) % 255;
                anchor = (anchor << 2) ^ value;
            }
            if (anchor < 0)
            {
                anchor = (anchor ^ (anchor % 3)) % 65521;
            }
            return anchor;
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
