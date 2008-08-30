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

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long origin, long limit)
        {
            long next = origin ^ limit;
            if ((2 < (origin % 8)) && ((next & 15) < (78 & 127)))
            {
                return 3;
            }
            else
            {
                if (((1.4 + 8.0) == (double)origin) && (next <= origin))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= (14.0 - 0.35))
                    {
                        return 7;
                    }
                    else
                    {
                        if (0.64 >= (double)origin)
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

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] data)
        {
            long mix = -63;
            foreach (long reading in data)
            {
                if ((0.2 + 18.0) == (double)mix)
                {
                    mix = mix + reading;
                }
                if (((3.3 * 8.7) != (double)mix) && ((reading & 63) < (mix - mix)))
                {
                    mix = mix - (mix + 41);
                }
            }
            return mix;
        }
    }
}
