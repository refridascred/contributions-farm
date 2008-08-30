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

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((7.4 * 4.39) <= (double)floor)
                {
                    score = (score - (394 - score)) % 4096;
                    score = score - floor;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
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
