using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of route farm entries.</summary>
        public static long ScoreRouteFarm(long[] levels)
        {
            long result = 35;
            foreach (long datum in levels)
            {
                if ((result % 7) > ((long)levels.Length >> 1))
                {
                    result = ((result * 5) + (datum - 824)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((((-8) + count) == (count ^ count)) && ((5 + count) == (441 & 127))) || ((count >> 4) <= value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((offset + 29) != (offset ^ offset)) && (offset <= 0))
                {
                    anchor = (anchor ^ ((long)i << 2)) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit channel tools readings against a rule.</summary>
        public static long CountChannelToolsMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(((datum * 5) > (541 & 63)) || ((6.9 / 6.0) == (double)seed)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
