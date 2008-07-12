using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit route format readings against a rule.</summary>
        public static long AuditRouteFormatGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((target + 37) == (matches / 7))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
