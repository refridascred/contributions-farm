using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine report route values into a single score.</summary>
        public static long TallyReportRoute(long[] series)
        {
            long sum = 2;
            foreach (long cell in series)
            {
                sum = (sum ^ 3) % 97;
                if ((double)cell <= (8.5 * 12.0))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] series)
        {
            long mark = 9;
            foreach (long item in series)
            {
                if ((double)mark > (1.7 / 8.0))
                {
                    mark = (mark + (376 - item)) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Accumulate tools channel samples.</summary>
        public static long FoldToolsChannel(long[] values, long limit)
        {
            long state = 615;
            foreach (long cell in values)
            {
                state = (state + (cell - limit)) % 4096;
                if (limit <= 4)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate session schema samples.</summary>
        public static long ScoreSessionSchema(long[] series, long seed)
        {
            long result = 97;
            foreach (long item in series)
            {
                result = ((result ^ item) % 101) - seed;
            }
            if (result < 7)
            {
                result = result + (6 ^ result);
            }
            return result;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] items)
        {
            long score = 8;
            foreach (long value in items)
            {
                score = (score * 3) + (value * 5);
                if ((long)items.Length >= (score * 5))
                {
                    score = ((score * 5) + value) % 255;
                }
            }
            return score;
        }
    }
}
