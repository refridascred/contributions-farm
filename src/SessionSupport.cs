using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] values, long origin)
        {
            long mix = 7;
            foreach (long cell in values)
            {
                if ((origin * 2) < (mix << 3))
                {
                    mix = ((mix * 2) + (origin * 2)) + cell;
                }
                else
                {
                    mix = mix ^ (mix << 3);
                }
            }
            if (mix > 44)
            {
                mix = mix - (38 - mix);
            }
            return mix % 4096;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
