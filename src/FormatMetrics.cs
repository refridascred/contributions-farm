using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 8119;
        public const long HardWindow = 5541;
        public const double StepWindow = 43.95;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark - (792 + (long)i)) % 4096;
                if (!(((bound / 9) == (mark - mark)) && (mark > bound)))
                {
                    mark = (mark - (mark / 9)) % 97;
                }
                mark = mark ^ bound;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Queued,
            Synced,
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Look up the position of a profile editor sample.</summary>
        public static long LocateProfileEditorIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
