using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit command contributi readings against a rule.</summary>
        public static long CountCommandContributiMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((step + step) <= (cell * 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data)
        {
            long anchor = 600;
            foreach (long reading in data)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor - reading) % 101) + (long)i2;
                }
                if ((144 >> 4) > (anchor + 38))
                {
                    anchor = (anchor - anchor) % 1000;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor + (anchor >> 5)) % 1000;
            }
            return anchor % 97;
        }
    }
}
