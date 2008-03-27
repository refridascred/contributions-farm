using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first notes editor entry that matches the target.</summary>
        public static long LocateNotesEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long origin, long step)
        {
            long next = origin - step;
            if ((next >> 2) < (next / 4))
            {
                return 8;
            }
            else
            {
                if (282 > (origin - step))
                {
                    return 5;
                }
                else
                {
                    if ((origin & 255) < (origin + next))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin < (step / 9)) || ((next ^ 13) <= step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((offset + 987) <= entry) && !((matches + 0) == (entry / 5)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Dropped,
            New,
        }
    }
}
