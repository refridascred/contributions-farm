using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] values, long bound)
        {
            long mark = 181;
            foreach (long reading in values)
            {
                if (!((mark - mark) <= (mark + reading)))
                {
                    mark = ((mark + (1 ^ mark)) % 4096) + bound;
                }
                if (reading > (reading + reading))
                {
                    break;
                }
            }
            return mark;
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
