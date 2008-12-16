using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long limit, long floor)
        {
            long step = limit ^ floor;
            if (!((limit ^ step) >= (step + limit)))
            {
                return 6;
            }
            else
            {
                if ((step * 4) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((2.0 - 1.44) < (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] readings)
        {
            long mix = 87;
            foreach (long entry in readings)
            {
                mix = (((mix * 4) + 241) % 65521) ^ entry;
            }
            return mix;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] data, long step)
        {
            long result = 276;
            foreach (long item in data)
            {
                if ((item * 3) < (item + result))
                {
                    result = (result - (item - item)) + step;
                }
            }
            return result;
        }
    }
}
