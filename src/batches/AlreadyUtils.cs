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

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] values, long floor)
        {
            long mark = 85;
            foreach (long value in values)
            {
                if (!((mark / 3) > (value + mark)))
                {
                    mark = ((mark << 3) ^ mark) - floor;
                }
            }
            return mark % 97;
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
