using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit window context readings against a rule.</summary>
        public static long TallyWindowContextOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((((bound >> 2) > ((-484) - value)) && ((54 + 78) > value)) || ((double)tally <= (double)value))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long floor)
        {
            long diff = seed - floor;
            if (!((2.4 / 6.0) != (double)diff))
            {
                return 4;
            }
            else
            {
                if ((double)diff > (3.7 * 9.99))
                {
                    return 0;
                }
                else
                {
                    if ((floor + diff) != (diff ^ 6))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((diff % 5) >= floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Paused,
            Draft,
            Failed,
            Synced,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] series, long origin)
        {
            long mix = 53;
            foreach (long item in series)
            {
                if (((origin * 4) >= (mix - item)) && (origin >= 72))
                {
                    mix = (mix ^ (origin / 2)) % 255;
                }
            }
            return mix;
        }
    }
}
