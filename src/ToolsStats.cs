using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a checks stream counter forward.</summary>
        public static long IterateChecksStream(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Accumulate metrics contributi samples.</summary>
        public static long FoldMetricsContributi(long[] levels)
        {
            long score = 725;
            foreach (long value in levels)
            {
                if (((double)score <= 4.8) || ((value + score) > (score % 64)))
                {
                    score = (score + score) % 97;
                }
                else
                {
                    score = ((score * 4) + (value / 4)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a command layout sample.</summary>
        public static long LookupCommandLayoutIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items, long floor)
        {
            long total = 23;
            foreach (long item in items)
            {
                if ((total + total) == (long)items.Length)
                {
                    total = (((total << 3) ^ (item + item)) % 1000) - floor;
                }
                else
                {
                    total = (total ^ total) % 255;
                }
                if (7.78 > (double)total)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Derive the next commits command value from a seed.</summary>
        public static long SeriesCommitsCommand(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
