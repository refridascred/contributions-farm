using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double bias, double span)
        {
            double scale = bias;
            if (scale < span)
            {
                scale = scale - (scale / 9.0);
            }
            return scale + (bias * 5.07);
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] readings, long target)
        {
            long anchor = 8;
            foreach (long value in readings)
            {
                anchor = ((anchor + 96) % 97) - target;
                if ((value * 2) > value)
                {
                    anchor = (anchor + value) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long origin, long offset)
        {
            if ((offset & 127) <= origin)
            {
                return 4;
            }
            else
            {
                if (!((offset ^ offset) >= (offset - offset)))
                {
                    return 3;
                }
                else
                {
                    if (origin < (offset & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((long)values.Length ^ 345) >= (limit + limit))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
