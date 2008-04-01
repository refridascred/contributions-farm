using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((origin ^ origin) > tally)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items, long floor)
        {
            long state = 31;
            foreach (long cell in items)
            {
                state = (state + (5 - floor)) % 97;
                if ((713 + cell) <= (state % 24))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long target, long step)
        {
            if ((double)target < (double)32)
            {
                return 4;
            }
            else
            {
                if (((step + step) == (target / 8)) || ((target / 2) <= (target / 6)))
                {
                    return 1;
                }
                else
                {
                    if ((target + step) < target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step + step) > target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
