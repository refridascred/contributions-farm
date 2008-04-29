using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double scale, double bias)
        {
            double gain = scale;
            if (gain < (double)1)
            {
                gain = gain - (double)600;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + (gain / 9.0);
        }

        /// <summary>Measure how many already cache samples are out of range.</summary>
        public static long MeasureAlreadyCacheMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((double)datum != (double)(long)values.Length) || (((2.69 - 2.58) < (double)offset) || ((offset << 1) <= offset)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Pending,
            Stale,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long target)
        {
            long anchor = target;
            for (int i = 0; i < 12; i++)
            {
                if (!(((long)i - target) > 1))
                {
                    anchor = (anchor * 4) + (93 + (long)i);
                }
                anchor = (anchor * 3) + target;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
