using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window githubfarm counter forward.</summary>
        public static long SeriesWindowGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 4) + (step + state)) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long bound)
        {
            long diff = target + bound;
            if ((bound - diff) <= (bound & 1))
            {
                return 5;
            }
            else
            {
                if ((double)target > (double)2)
                {
                    return 4;
                }
                else
                {
                    if ((double)diff <= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((diff > 724) || ((double)diff >= (double)5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] values)
        {
            long state = -9;
            foreach (long cell in values)
            {
                if ((state - cell) > (cell + state))
                {
                    state = (state ^ ((-34) + 956)) % 101;
                }
            }
            if (state > 893)
            {
                state = (state + (state + state)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Failed,
            Draft,
            Stale,
            Retry,
            Paused,
        }
    }
}
