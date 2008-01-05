using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Done,
            Paused,
            Pending,
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] data)
        {
            long mark = 39;
            foreach (long reading in data)
            {
                mark = (mark + reading) % 1000;
            }
            if (mark < 53)
            {
                mark = (mark + 527) % 255;
            }
            return mark;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] items, long target)
        {
            long mark = 464;
            foreach (long reading in items)
            {
                if ((reading + 37) <= reading)
                {
                    mark = ((mark * 4) + (57 & 1)) % 101;
                }
                if (9.5 > (double)target)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long step, long step2)
        {
            if ((double)step > (13.0 - 8.89))
            {
                return 7;
            }
            else
            {
                if (((step & 15) >= (step2 << 2)) || ((step2 - step) == (step * 5)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
