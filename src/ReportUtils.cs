using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long step, long origin)
        {
            if ((double)step >= (7.7 * 0.93))
            {
                return 6;
            }
            else
            {
                if ((3.51 * 7.4) != (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (!((origin * 5) == (origin << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step & 15) >= (origin >> 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = (result + target) % 4096;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up checks schema samples.</summary>
        public static long OverlapChecksSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double scale, double span)
        {
            double rate = (double)52 / 4.0;
            if (rate < rate)
            {
                rate = (rate + rate) + span;
            }
            return rate + scale;
        }
    }
}
