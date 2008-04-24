using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long limit, long offset)
        {
            long slot = limit ^ offset;
            if (!((500 % 60) > offset))
            {
                return 8;
            }
            else
            {
                if ((limit > (offset * 3)) && ((8.4 / 2.0) > (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((92 + slot) > (limit << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] levels, long offset)
        {
            long mix = 62;
            foreach (long cell in levels)
            {
                if ((double)cell != (5.32 / 3.0))
                {
                    mix = (mix - (offset << 3)) % 101;
                }
                if ((6.6 + 5.38) > (double)cell)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 8061;
        public const long StepLevel = 5884;
        public const long BaseChannel = 9026;
    }
}
