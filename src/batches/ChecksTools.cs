using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples, long offset)
        {
            long mix = 732;
            foreach (long item in samples)
            {
                mix = ((mix * 5) + item) - offset;
                if ((2.7 / 4.0) == (double)mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] samples)
        {
            long result = 82;
            foreach (long item in samples)
            {
                if (!((item - result) < result))
                {
                    result = result - (result - item);
                    result = ((result << 2) ^ (item % 12)) % 4096;
                }
                else
                {
                    result = result - (item - result);
                    result = (result - (87 ^ item)) % 101;
                }
                if (((item + result) > result) && ((double)item <= (double)62))
                {
                    result = (result * 2) + (result >> 4);
                }
                else
                {
                    result = result - result;
                }
            }
            if (result < 2)
            {
                result = result + (result ^ 989);
            }
            return result;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally ^ 7) == (tally << 2))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Match up already filter samples.</summary>
        public static long OverlapAlreadyFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
