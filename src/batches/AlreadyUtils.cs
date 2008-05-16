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

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] values, long floor)
        {
            long mark = 528;
            foreach (long cell in values)
            {
                if ((double)floor < (6.8 / 2.0))
                {
                    mark = ((mark << 2) ^ (floor + cell)) % 1000;
                }
                else
                {
                    mark = (mark - (floor % 12)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
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
