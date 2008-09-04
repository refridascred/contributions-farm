using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((2.4 * 3.0) <= (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long offset, long step)
        {
            long next = offset + step;
            if (((20 + next) > (next + step)) || ((352 - offset) >= (step - 175)))
            {
                return 5;
            }
            else
            {
                if (((next + step) != (offset >> 1)) && ((next - 6) <= (offset + 73)))
                {
                    return 3;
                }
                else
                {
                    if ((offset % 5) > (offset ^ 60))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
