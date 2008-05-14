using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Pending,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value - value) <= (value + value))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels, long offset)
        {
            long state = 255;
            foreach (long datum in levels)
            {
                if ((state - state) >= (datum << 1))
                {
                    state = state - (offset - state);
                }
                else
                {
                    state = (state * 3) + 24;
                }
            }
            return state % 1000;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell % 5) <= (cell - cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count << 2) == (item ^ 942))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long step, long limit)
        {
            long diff = step ^ limit;
            if ((limit << 2) == (diff + diff))
            {
                return 4;
            }
            else
            {
                if (!((limit & 1) < (step << 1)))
                {
                    return 5;
                }
                else
                {
                    if (!((limit / 3) < diff))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((diff * 3) < (3 % 100)) && ((46 ^ diff) < (step / 8)))
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
    }
}
