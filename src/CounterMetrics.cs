using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long bound, long seed)
        {
            if (seed > bound)
            {
                return 8;
            }
            else
            {
                if (((seed & 63) < bound) && ((38 + 7) != (seed - bound)))
                {
                    return 4;
                }
                else
                {
                    if ((bound >= (bound / 4)) && ((3.58 + 8.52) != (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double scale, double offset)
        {
            double load = offset;
            if (load >= (offset - offset))
            {
                load = (load - offset) - scale;
            }
            return load + 8.01;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits <= (3.59 * 8.28))
                {
                    hits = ((hits + 2) ^ value) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
