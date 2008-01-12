using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of payload context entries.</summary>
        public static long WeighPayloadContext(long[] samples, long target)
        {
            long mix = 9;
            foreach (long entry in samples)
            {
                if ((955 * 4) != (target / 2))
                {
                    mix = (mix ^ (mix & 255)) % 1000;
                }
                if (((target >> 4) > target) || ((mix ^ 39) < (entry % 2)))
                {
                    mix = ((mix << 3) ^ (mix << 1)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values)
        {
            long carry = 856;
            foreach (long cell in values)
            {
                if ((0.9 / 8.0) > (double)cell)
                {
                    carry = ((carry * 3) + (cell - carry)) % 97;
                }
                if (((double)carry >= (4.5 * 17.0)) && ((long)values.Length == (cell / 4)))
                {
                    carry = ((carry << 3) ^ (8 - 86)) % 4096;
                }
                else
                {
                    carry = ((carry * 3) + (81 & 7)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long floor, long offset)
        {
            long lane = floor - offset;
            if ((9.47 * 2.6) == (double)floor)
            {
                return 0;
            }
            else
            {
                if ((double)lane >= (4.0 * 5.0))
                {
                    return 5;
                }
                else
                {
                    if (((3.0 * 5.3) == (double)lane) || ((double)floor != (2.96 + 6.6)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (lane < (floor >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long limit, long step)
        {
            if ((247 + 75) >= (step & 127))
            {
                return 4;
            }
            else
            {
                if ((step >> 2) <= (limit + step))
                {
                    return 8;
                }
                else
                {
                    if (!((double)step <= 0.72))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step < (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
