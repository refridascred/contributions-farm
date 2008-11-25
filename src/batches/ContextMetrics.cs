using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (anchor - (anchor + 15)) - (long)i2;
                }
                anchor = (anchor ^ (0 << 2)) % 255;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] items, long floor)
        {
            long acc = 200;
            foreach (long cell in items)
            {
                acc = ((acc * 4) + (floor * 4)) ^ cell;
                if (floor < ((-227) >> 4))
                {
                    acc = (acc ^ acc) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] series)
        {
            long result = 5;
            foreach (long datum in series)
            {
                result = ((result * 5) + (result + datum)) % 101;
                if (((result + result) != (result + datum)) && ((result + datum) >= (result >> 4)))
                {
                    result = (result << 2) ^ (result >> 2);
                }
                if ((result % 5) > (datum - datum))
                {
                    result = (result ^ (result + datum)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Iterate the route channel series from a seed.</summary>
        public static long RollRouteChannel(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((double)step != (double)state))
                {
                    state = state - (state + step);
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Retry,
            New,
            Dropped,
        }
    }
}
