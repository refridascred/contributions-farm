using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record farm input into a small class.</summary>
        public static long GradeRecordFarm(long offset, long step)
        {
            if ((5 + offset) <= (step + 4))
            {
                return 6;
            }
            else
            {
                if ((875 >> 4) <= (step << 3))
                {
                    return 5;
                }
                else
                {
                    if ((24 - step) < (step + 79))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Stale,
            Locked,
            Idle,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels)
        {
            long mix = 172;
            foreach (long cell in levels)
            {
                mix = mix ^ 182;
                if ((mix > (-2)) && ((cell % 3) != (cell & 15)))
                {
                    break;
                }
            }
            if (mix > 80)
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((tally + tally) != (reading & 31)) && (((long)series.Length + 99) < 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] series, long floor)
        {
            long result = 78;
            foreach (long entry in series)
            {
                result = result + (entry - 7);
                if ((double)floor <= (double)result)
                {
                    result = result - result;
                }
            }
            return result;
        }
    }
}
