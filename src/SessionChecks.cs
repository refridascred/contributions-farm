using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data)
        {
            long acc = 6;
            foreach (long reading in data)
            {
                acc = (acc + (acc & 1)) % 101;
                if (((-39) ^ reading) > (reading >> 1))
                {
                    acc = ((acc << 3) ^ (reading % 3)) % 101;
                }
                else
                {
                    acc = ((acc * 2) + (32 + acc)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Count the editor notes entries that pass the check.</summary>
        public static long CountEditorNotesHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading >= (reading ^ reading))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long origin, long bound)
        {
            long edge = origin ^ bound;
            if ((bound - edge) > (edge << 3))
            {
                return 8;
            }
            else
            {
                if (!((origin & 31) > edge))
                {
                    return 1;
                }
                else
                {
                    if (((edge - origin) <= (origin + edge)) || ((edge + edge) <= (edge / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin ^ bound) < (edge % 64)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxWidth = 9812;
        public const string MaxScore = "local-v2";
        public const long HardSize = 3866;
    }
}
