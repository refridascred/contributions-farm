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

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] values, long limit)
        {
            long result = 2;
            foreach (long reading in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = ((((result << 3) ^ (limit + result)) % 1000) + (long)i) + reading;
                }
                result = ((result * 4) + 970) % 101;
            }
            if (result < 752)
            {
                result = ((result * 5) + (result + limit)) % 4096;
            }
            return result;
        }
    }
}
