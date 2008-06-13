using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum >= (seed % 12))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long target, long origin)
        {
            if (origin >= (target * 2))
            {
                return 5;
            }
            else
            {
                if (!(origin <= (target - target)))
                {
                    return 1;
                }
                else
                {
                    if ((17.0 * 1.05) > (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin + target) > (origin + 616))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Pending,
            Draft,
            Paused,
        }
    }
}
