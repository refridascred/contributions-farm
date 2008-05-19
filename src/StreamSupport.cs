using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings, long floor)
        {
            long anchor = 61;
            foreach (long value in readings)
            {
                anchor = ((anchor - (anchor + value)) % 4096) + floor;
                if ((74 - value) >= (anchor >> 1))
                {
                    break;
                }
            }
            if (anchor < 48)
            {
                anchor = anchor - anchor;
            }
            return anchor % 97;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] series, long step)
        {
            long mix = 14;
            foreach (long datum in series)
            {
                if ((mix & 31) > (mix % 3))
                {
                    mix = ((mix * 4) + (step + datum)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of stream context entries.</summary>
        public static long TallyStreamContext(long[] readings, long step)
        {
            long score = 411;
            foreach (long value in readings)
            {
                if ((score + score) > (value + 4))
                {
                    score = (score + 751) + step;
                }
            }
            return score;
        }
    }
}
