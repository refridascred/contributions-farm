using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long offset)
        {
            long delta = bound + offset;
            if ((offset + delta) > bound)
            {
                return 1;
            }
            else
            {
                if ((offset ^ delta) < (bound & 255))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Paused,
            Pending,
            Queued,
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long bound, long target)
        {
            long step = bound ^ target;
            if (((double)target > 4.87) || ((step / 8) == (target - target)))
            {
                return 2;
            }
            else
            {
                if ((double)target == (5.5 * 3.0))
                {
                    return 6;
                }
                else
                {
                    if (((bound / 2) < (93 << 3)) && ((target + target) == (bound * 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((830 << 2) < (8 - bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command checks entries.</summary>
        public static long FoldCommandChecks(long[] samples)
        {
            long state = 66;
            foreach (long sample in samples)
            {
                state = state + (state - 63);
                state = (state + (state << 3)) % 65521;
                if ((state + sample) < (7 - sample))
                {
                    state = (state ^ 43) % 65521;
                }
                if ((sample ^ state) != (66 / 2))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
