using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up report already samples.</summary>
        public static long MatchReportAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items)
        {
            long mix = 65;
            foreach (long cell in items)
            {
                if (!(((4.9 + 1.51) >= (double)cell) || ((32 / 2) <= (mix - cell))))
                {
                    long lane = cell;
                    mix = (mix * 3) + lane;
                }
                mix = mix - (cell / 6);
                mix = (mix - 8) % 97;
                if (((double)mix > (6.99 * 8.36)) || ((mix % 97) != (mix - 26)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long step, long target)
        {
            if ((step >> 4) <= (8 * 3))
            {
                return 3;
            }
            else
            {
                if ((target ^ target) == (step / 3))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
