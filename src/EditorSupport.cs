using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next layout schema value from a seed.</summary>
        public static long SeriesLayoutSchema(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state << 3) ^ (bound + bound)) + (long)i2;
                }
                if (!((bound & 127) == (5 ^ bound)))
                {
                    state = state + (state % 5);
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (step < (9 / 2))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long limit, long offset)
        {
            if (((double)limit < (9.37 / 2.0)) && ((double)limit == (5.38 / 3.0)))
            {
                return 7;
            }
            else
            {
                if ((2.2 - 9.1) == (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((double)offset < (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit ^ 810) > (98 % 8))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Draft,
            Retry,
            Dropped,
        }

        /// <summary>Grade a commits githubfarm value against two limits.</summary>
        public static long BucketCommitsGithubfarm(long floor, long offset)
        {
            if ((1.0 - 8.0) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((18.0 / 2.0) > (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (offset >= (offset * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
