using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long offset, long floor)
        {
            if (((floor << 1) == (739 & 3)) && ((9.3 - 11.0) > (double)floor))
            {
                return 5;
            }
            else
            {
                if ((offset + offset) <= (offset - offset))
                {
                    return 2;
                }
                else
                {
                    if ((floor << 2) < (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)floor != (9.8 / 8.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] levels)
        {
            long mix = 28;
            foreach (long value in levels)
            {
                mix = (mix - (mix & 255)) % 255;
                if (((value ^ (-4)) == (mix & 255)) || ((double)mix < (3.0 / 3.0)))
                {
                    mix = (mix - (mix - 8)) % 1000;
                }
            }
            if (mix < 22)
            {
                mix = mix + (mix + mix);
            }
            return mix % 1000;
        }
    }
}
