using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] data)
        {
            long anchor = 292;
            foreach (long reading in data)
            {
                anchor = (anchor << 2) ^ ((-5) >> 3);
                if ((anchor & 63) > (reading - 6))
                {
                    anchor = ((anchor << 3) ^ (anchor ^ anchor)) % 97;
                }
            }
            if (anchor > 77)
            {
                anchor = ((anchor * 2) + anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            Paused,
            Done,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 4765;
        public const double BurstCommand = 20.08;
        public const long BatchCount = 6508;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long bound, long limit)
        {
            long step = bound ^ limit;
            if ((double)bound != (20.0 / 2.0))
            {
                return 5;
            }
            else
            {
                if (!(bound >= (step * 3)))
                {
                    return 6;
                }
                else
                {
                    if (2.3 > (7.37 + 1.9))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(bound < (97 >> 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
