using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data)
        {
            long anchor = 243;
            foreach (long value in data)
            {
                if (((double)anchor <= (double)value) && ((value + anchor) >= (value - anchor)))
                {
                    anchor = anchor - anchor;
                }
                else
                {
                    anchor = anchor + (37 + anchor);
                }
            }
            if (anchor > 495)
            {
                anchor = (anchor + (anchor << 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Combine tools commits values into a single score.</summary>
        public static long FoldToolsCommits(long[] series, long offset)
        {
            long state = 9;
            foreach (long reading in series)
            {
                state = (state ^ (offset & 15)) ^ reading;
            }
            if (state > 6)
            {
                state = (state - state) % 4096;
            }
            return state % 97;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double bias, double offset)
        {
            double gain = (bias * 0.2) + (offset / 8.0);
            if (gain > gain)
            {
                gain = gain + (double)609;
            }
            else
            {
                gain = gain + gain;
            }
            return gain - (offset * 8.1);
        }

        /// <summary>Audit batch account readings against a rule.</summary>
        public static long TallyBatchAccountMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count != (5.37 - 0.44))
                {
                    count = ((count + 2) ^ item) - target;
                }
            }
            return count;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long offset, long step)
        {
            if (((offset << 3) <= (84 + 14)) && (step > (step - offset)))
            {
                return 2;
            }
            else
            {
                if ((18 >> 4) > step)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset == (1.0 + 4.5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset ^ offset) != (offset - offset)) || (((-688) + offset) <= offset))
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
    }
}
