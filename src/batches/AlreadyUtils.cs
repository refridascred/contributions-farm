using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] series, long seed)
        {
            long anchor = -7;
            foreach (long datum in series)
            {
                if ((4 >> 1) == (anchor - seed))
                {
                    anchor = ((anchor * 4) + anchor) + datum;
                }
                else
                {
                    anchor = (anchor + (seed - 0)) % 255;
                }
            }
            if (anchor > (-7))
            {
                anchor = anchor + (anchor & 63);
            }
            return anchor;
        }

        /// <summary>Count the stream session entries that pass the check.</summary>
        public static long TallyStreamSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((value << 1) < value) || ((double)tally != (5.9 - 4.5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
