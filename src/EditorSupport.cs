using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepWidth = 62.75;
        public const long MinCluster = 1947;
        public const long RetryInterval = 2598;
        public const long StepLevel = 8575;

        /// <summary>Measure how many batch buffer samples are out of range.</summary>
        public static long MeasureBatchBufferMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum ^ seen) <= (56 << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Match up channel route samples.</summary>
        public static long OverlapChannelRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
