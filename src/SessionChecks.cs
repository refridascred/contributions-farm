using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank contributi already input into a small class.</summary>
        public static long SortContributiAlready(long offset, long step)
        {
            long cur = offset - step;
            if ((step + step) > (offset & 255))
            {
                return 5;
            }
            else
            {
                if (!((cur - 25) > offset))
                {
                    return 0;
                }
                else
                {
                    if ((step * 4) > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((cur * 3) <= cur) && ((double)step < (3.75 - 6.0)))
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

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Queued,
            Draft,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Count counter channel pairs that satisfy a relation.</summary>
        public static long PairCounterChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of support account readings.</summary>
        public static long CompareSupportAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
