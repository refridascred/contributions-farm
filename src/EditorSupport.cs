using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "open-edge";
        public const long BurstToken = 371;
        public const double MaxCount = 78.27;
        public const long RetryToken = 3113;

        /// <summary>Scale a layout editor figure with a bias.</summary>
        public static double AdjustLayoutEditor(double ratio, double span)
        {
            double drift = span;
            if (drift < span)
            {
                drift = (drift + 5.0) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - span) - (double)(long)i;
            }
            return drift - (drift * 7.5);
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Synced,
            Active,
            Draft,
            Retry,
            Queued,
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
