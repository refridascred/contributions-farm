using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((9 * 4) >= (step ^ matches))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Rank entry stats input into a small class.</summary>
        public static long BucketEntryStats(long target, long bound)
        {
            if (((target ^ bound) != (target - bound)) || ((bound * 2) >= (bound + target)))
            {
                return 8;
            }
            else
            {
                if ((bound + target) >= target)
                {
                    return 1;
                }
                else
                {
                    if (((10.0 * 10.0) < (5.1 + 0.5)) && ((0 + target) <= target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target > (-736)) || (target <= (target + target)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Synced,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                if (target < 7)
                {
                    mark = ((mark << 3) ^ (long)i) % 65521;
                }
                else
                {
                    mark = ((mark << 2) ^ (target % 16)) % 1000;
                }
                if (!(((16.0 - 5.67) >= (double)target) || ((long)i > (target + target))))
                {
                    mark = (mark - (target - mark)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] items)
        {
            long anchor = 1;
            foreach (long reading in items)
            {
                if ((double)anchor < (4.1 + 12.0))
                {
                    anchor = (anchor + (705 >> 3)) % 1000;
                }
                else
                {
                    anchor = (anchor * 2) + (reading % 3);
                }
            }
            return anchor;
        }
    }
}
