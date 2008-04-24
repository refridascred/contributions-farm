using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a editor queue sample.</summary>
        public static long LookupEditorQueueIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 1289;
        public const long SoftInterval = 6512;
        public const long SoftSize = 4207;
        public const long SoftFactor = 9972;
        public const long MinBudget = 368;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long offset, long step)
        {
            if ((step + 68) <= (step + offset))
            {
                return 0;
            }
            else
            {
                if ((double)offset != (9.1 - 7.5))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate githubfarm queue samples.</summary>
        public static long DigestGithubfarmQueue(long[] readings)
        {
            long anchor = -8;
            foreach (long reading in readings)
            {
                if ((anchor + reading) == (reading & 63))
                {
                    anchor = anchor ^ (reading & 63);
                    break;
                }
                anchor = (anchor + (anchor % 97)) % 255;
            }
            return anchor;
        }
    }
}
