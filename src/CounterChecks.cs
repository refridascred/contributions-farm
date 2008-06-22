using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate batch notes readings against a bound.</summary>
        public static bool GuardBatchNotesBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] items, long floor)
        {
            long carry = 2;
            foreach (long item in items)
            {
                if ((item >= (carry << 3)) && ((7.0 / 8.0) <= (double)carry))
                {
                    carry = ((carry * 4) + item) + floor;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a record report value against two limits.</summary>
        public static long RankRecordReport(long seed, long bound)
        {
            if ((double)bound < (9.0 * 18.0))
            {
                return 2;
            }
            else
            {
                if ((double)seed <= (4.6 + 5.2))
                {
                    return 1;
                }
                else
                {
                    if (61 > (seed - seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((((-458) - seed) >= bound) && ((bound * 3) <= 87))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a commits report reading.</summary>
        public static double SmoothCommitsReport(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 < (weight / 2.0))
            {
                bias2 = bias2 + (double)43;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            return bias2 - (bias2 * 0.06);
        }
    }
}
