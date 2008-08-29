using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit filter record readings against a rule.</summary>
        public static long TallyFilterRecordGaps(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)bound < (4.82 / 7.0))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank entry command input into a small class.</summary>
        public static long GradeEntryCommand(long bound, long offset)
        {
            long diff = bound ^ offset;
            if (!((diff + offset) >= diff))
            {
                return 2;
            }
            else
            {
                if ((offset ^ diff) <= (offset + offset))
                {
                    return 8;
                }
                else
                {
                    if (((3.34 / 5.0) > (double)bound) && ((-6) < (diff / 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((11.0 - 7.76) < (8.0 + 1.3)) && ((offset + bound) == (diff >> 3)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] readings)
        {
            long acc = 165;
            foreach (long reading in readings)
            {
                acc = (acc << 3) ^ (reading - reading);
            }
            return acc;
        }
    }
}
