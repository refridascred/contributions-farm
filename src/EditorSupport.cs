using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Active,
            Closed,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Paused,
            Closed,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 3) ^ (mark * 5)) % 255;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(bound > (count - bound)))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Adjust a session already reading.</summary>
        public static double ProjectSessionAlready(double bias, double bias2)
        {
            double ratio = (bias / 7.0) - 5.0;
            return (ratio - (double)37) + bias2;
        }

        /// <summary>Count the route commits entries that pass the check.</summary>
        public static long CountRouteCommitsOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((9.2 + 0.99) < (double)value)
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
