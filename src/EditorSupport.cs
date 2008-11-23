using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Idle,
            Active,
            Done,
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double AdjustTools(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 < 4.31)
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (double)91) - (double)(long)i;
            }
            return scale2 - (scale2 - floor);
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long floor, long step)
        {
            long offset = floor ^ step;
            if ((floor + offset) >= (offset / 4))
            {
                return 5;
            }
            else
            {
                if ((offset % 3) >= (floor & 7))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor <= 8.03)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((197 + step) <= (step << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi counter entries.</summary>
        public static long TallyContributiCounter(long[] readings)
        {
            long mix = 83;
            foreach (long value in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix << 3) ^ (value ^ mix)) % 255) + (long)i;
                }
                mix = (mix - (592 & 127)) % 101;
            }
            return mix;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Retry,
            Stale,
            Locked,
            Failed,
        }

        /// <summary>Audit graph window readings against a rule.</summary>
        public static long AuditGraphWindowMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (269 < (sample << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
