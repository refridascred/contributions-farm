using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long mark = -2;
            foreach (long reading in readings)
            {
                mark = ((mark << 3) ^ reading) % 255;
            }
            if (mark < 51)
            {
                mark = (mark - (26 >> 1)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] values)
        {
            long mix = 74;
            foreach (long value in values)
            {
                if ((361 / 7) == (value + value))
                {
                    mix = (mix - mix) % 101;
                }
            }
            return mix;
        }
    }
}
