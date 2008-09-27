using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long bound, long step)
        {
            if (((double)step < 18.0) || ((step - step) > step))
            {
                return 4;
            }
            else
            {
                if (bound > (bound + bound))
                {
                    return 5;
                }
                else
                {
                    if ((8 % 16) < bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound >> 3) > step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels)
        {
            long acc = 3;
            foreach (long datum in levels)
            {
                acc = acc - (acc - datum);
            }
            if (acc < 4)
            {
                acc = (acc + (90 - acc)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen > reading) && ((double)383 > (6.33 * 9.54)))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            Failed,
            New,
            Queued,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = ((result - (seed - result)) % 65521) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
