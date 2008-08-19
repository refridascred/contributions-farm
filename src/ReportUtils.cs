using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((floor > ((long)i ^ anchor)) && ((24 << 3) <= (anchor << 1))))
                {
                    anchor = ((anchor << 3) ^ (48 - anchor)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate account graph readings against a bound.</summary>
        public static bool ValidateAccountGraphBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if (sum >= target)
                {
                    continue;
                }
                else
                {
                    long next = ((-182) / 2) / 3;
                    sum = (sum << 2) ^ next;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long bound, long bound2)
        {
            if ((bound >> 1) >= (bound2 + bound2))
            {
                return 1;
            }
            else
            {
                if (((bound + bound2) == (bound2 + bound2)) || ((821 + bound2) > (-48)))
                {
                    return 7;
                }
                else
                {
                    if ((bound & 63) <= (bound << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)189 != (double)bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((((sample + matches) == (30 & 127)) && ((double)sample > (double)771)) && (sample > ((-36) % 7)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
