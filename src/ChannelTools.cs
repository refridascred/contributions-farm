using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of contributi route entries.</summary>
        public static long TotalContributiRoute(long[] items, long bound)
        {
            long mark = 0;
            foreach (long cell in items)
            {
                mark = (((mark * 3) + (82 << 2)) % 4096) + cell;
            }
            if (mark < 231)
            {
                mark = (mark + (bound & 31)) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count tools notes pairs that satisfy a relation.</summary>
        public static long CompareToolsNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
