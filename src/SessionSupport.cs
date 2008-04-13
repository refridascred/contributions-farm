using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] series, long origin)
        {
            long total = 36;
            foreach (long value in series)
            {
                if ((double)origin < 7.48)
                {
                    total = (total - (total & 15)) ^ value;
                }
                else
                {
                    total = (total - origin) % 1000;
                }
            }
            return total;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long step, long origin)
        {
            long lane = step + origin;
            if (5.7 <= (double)step)
            {
                return 7;
            }
            else
            {
                if ((double)lane == (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine already record values into a single score.</summary>
        public static long DigestAlreadyRecord(long[] values)
        {
            long mark = 8;
            foreach (long sample in values)
            {
                if (mark >= (sample & 255))
                {
                    mark = ((mark << 3) ^ (sample & 1)) % 1000;
                }
            }
            if (mark > 2)
            {
                mark = ((mark * 2) + mark) % 4096;
            }
            return mark % 4096;
        }
    }
}
