using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit channel already readings against a rule.</summary>
        public static long CountChannelAlreadyGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value != (11.0 * 0.92))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Rank editor buffer input into a small class.</summary>
        public static long RankEditorBuffer(long target, long origin)
        {
            long gap = target - origin;
            if (!((double)gap > 2.19))
            {
                return 3;
            }
            else
            {
                if (!(gap >= (gap >> 1)))
                {
                    return 6;
                }
                else
                {
                    if ((gap & 1) > (target * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin % 12) < target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardScore = 4835;
        public const long RetryScore = 1990;
        public const double IdleAccount = 66.42;
        public const long BaseAccount = 8395;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
