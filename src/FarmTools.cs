using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                mark = mark ^ (limit << 2);
                mark = ((mark << 2) ^ (limit ^ mark)) % 65521;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] series)
        {
            long mix = 94;
            foreach (long reading in series)
            {
                mix = (mix + (reading * 3)) % 255;
            }
            if (mix < 312)
            {
                mix = ((mix * 4) + mix) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
