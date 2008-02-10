using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Stale,
            Paused,
            Draft,
            New,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Queued,
            Dropped,
            Idle,
            Ready,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] readings)
        {
            long acc = 993;
            foreach (long cell in readings)
            {
                if (((27 >> 1) <= acc) && ((double)acc <= (4.7 / 8.0)))
                {
                    acc = ((acc * 5) + (cell + acc)) % 1000;
                }
                else
                {
                    acc = (acc - acc) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Match up metrics token samples.</summary>
        public static long PairMetricsTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
