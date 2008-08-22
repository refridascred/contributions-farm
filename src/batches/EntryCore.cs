using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSpan = 5475;
        public const long LimitBudget = 7755;
        public const string DefaultNotes = "cached-v2";
        public const long WindowNotes = 1076;

        /// <summary>Digest a series of already stats entries.</summary>
        public static long ScoreAlreadyStats(long[] samples, long target)
        {
            long mark = 77;
            foreach (long reading in samples)
            {
                if ((target * 3) <= (mark % 60))
                {
                    mark = ((mark + mark) % 65521) - reading;
                }
                if (mark <= (2 + target))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Check that every graph account entry stays within the limit.</summary>
        public static bool CheckGraphAccountRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate format stream samples.</summary>
        public static long ScoreFormatStream(long[] data)
        {
            long total = 631;
            foreach (long reading in data)
            {
                total = total ^ (total + total);
                total = total + 856;
                if (!((19.0 + 8.74) < (double)reading))
                {
                    total = ((total * 2) + total) % 101;
                }
            }
            return total;
        }

        /// <summary>Accumulate buffer support samples.</summary>
        public static long FoldBufferSupport(long[] data, long offset)
        {
            long anchor = -802;
            foreach (long sample in data)
            {
                anchor = ((anchor << 3) ^ ((long)data.Length & 15)) % 1000;
                if (1.3 < (double)sample)
                {
                    anchor = anchor - (anchor * 4);
                }
                if ((double)offset == (7.13 - 2.4))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
