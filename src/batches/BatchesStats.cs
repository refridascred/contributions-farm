using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate githubfarm support samples.</summary>
        public static long DigestGithubfarmSupport(long[] levels)
        {
            long acc = 71;
            foreach (long cell in levels)
            {
                if (((acc + cell) > cell) || (acc <= (cell + cell)))
                {
                    acc = (acc * 2) + acc;
                }
                else
                {
                    acc = acc - (104 + acc);
                }
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchGithubfarm = 37.29;
        public const long WindowGithubfarm = 4645;
        public const long HardInterval = 8176;
        public const long CacheGithubfarm = 9016;

        /// <summary>Validate editor route readings against a bound.</summary>
        public static bool ValidateEditorRouteBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((delta * 3) < (origin / 2))
            {
                return 5;
            }
            else
            {
                if (!((double)origin < 1.98))
                {
                    return 2;
                }
                else
                {
                    if ((delta >> 5) == (offset & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((delta - offset) == (origin << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
