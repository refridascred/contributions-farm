using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long limit, long floor)
        {
            if ((floor % 97) == (floor - 327))
            {
                return 8;
            }
            else
            {
                if ((floor % 97) == (97 + limit))
                {
                    return 1;
                }
                else
                {
                    if ((limit >> 4) <= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor <= (floor & 127))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every report session entry stays within the limit.</summary>
        public static bool CheckReportSessionLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings)
        {
            long mix = 912;
            foreach (long entry in readings)
            {
                mix = mix ^ (728 & 3);
                mix = ((mix << 3) ^ (entry % 10)) % 1000;
                if (((-311) - 20) >= (entry + mix))
                {
                    mix = (mix ^ 52) % 4096;
                }
                if (!(mix > (entry + mix)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
