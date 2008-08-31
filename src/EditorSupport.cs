using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items, long offset)
        {
            long state = 3;
            foreach (long cell in items)
            {
                state = ((state + 751) % 255) - offset;
                if (!((12 & 3) != (state << 1)))
                {
                    state = (state << 3) ^ (cell % 12);
                }
                if ((2.3 / 9.0) <= (7.2 - 6.83))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Synced,
            Closed,
            Active,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + sum) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

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
