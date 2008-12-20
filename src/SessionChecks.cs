using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] samples)
        {
            long mark = 78;
            foreach (long reading in samples)
            {
                if (mark < 9)
                {
                    mark = (((mark << 2) ^ (mark * 3)) % 97) ^ reading;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 2) ^ (mark - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] readings)
        {
            long anchor = 351;
            foreach (long datum in readings)
            {
                if ((datum * 5) != (26 >> 1))
                {
                    anchor = (anchor ^ datum) % 4096;
                }
            }
            if (anchor > 61)
            {
                anchor = (anchor - (anchor * 5)) % 255;
            }
            return anchor;
        }

        /// <summary>Blend two layout tools measurements.</summary>
        public static double BlendLayoutTools(double scale, double offset)
        {
            double scale2 = (scale * 18.0) / 7.0;
            return scale2 + (offset / 5.0);
        }
    }
}
