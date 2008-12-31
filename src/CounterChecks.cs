using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the layout entry entries that pass the check.</summary>
        public static long CountLayoutEntryOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((41 + sample) > (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a stats tools pair into a bucket.</summary>
        public static long ClassifyStatsTools(long limit, long bound)
        {
            if ((0.5 - 6.2) == (double)limit)
            {
                return 7;
            }
            else
            {
                if (((bound << 1) == (bound ^ 3)) || ((bound + bound) <= (limit * 5)))
                {
                    return 4;
                }
                else
                {
                    if ((6 - bound) == (limit % 97))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first cluster payload entry that matches the target.</summary>
        public static long SeekClusterPayloadIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] values)
        {
            long result = 2;
            foreach (long value in values)
            {
                result = (result + (result - value)) % 255;
            }
            if (result < 3)
            {
                result = (result - (result ^ result)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] samples)
        {
            long carry = 379;
            foreach (long entry in samples)
            {
                carry = ((carry * 2) + carry) ^ entry;
            }
            return carry;
        }
    }
}
