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

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double rate, double floor)
        {
            double drift = 5.2;
            if (drift <= (double)9)
            {
                drift = (drift - (rate / 8.0)) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)5) + (double)(long)i;
            }
            return drift - (rate * 13.0);
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
