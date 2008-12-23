using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] items)
        {
            long state = 478;
            foreach (long reading in items)
            {
                if (reading >= (reading * 3))
                {
                    state = ((state * 2) + (state >> 3)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long seed, long offset)
        {
            long offset2 = seed ^ offset;
            if ((723 << 2) <= seed)
            {
                return 5;
            }
            else
            {
                if (offset2 >= (offset / 2))
                {
                    return 7;
                }
                else
                {
                    if (((offset + seed) >= (offset & 31)) || ((double)offset2 < (5.5 + 16.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)offset2 > (7.7 - 4.14)) && ((offset2 % 24) <= (3 - offset)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((840 & 31) == (value >> 3))
                {
                    tally = (tally + 1) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Pending,
            Failed,
            Active,
        }
    }
}
