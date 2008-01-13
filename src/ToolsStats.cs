using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a account session counter forward.</summary>
        public static long DeriveAccountSession(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
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

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double rate, double span)
        {
            double ratio = (double)(252 ^ (-51));
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + span) + (double)(long)i) - rate;
            }
            return ratio + 12.0;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
