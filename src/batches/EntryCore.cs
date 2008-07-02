using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Locked,
            Paused,
            Pending,
        }

        /// <summary>Adjust a report notes reading.</summary>
        public static double ProjectReportNotes(double ratio, double bias)
        {
            double load = bias;
            if (load > (bias / 8.0))
            {
                load = (load - (double)96) - ratio;
            }
            else
            {
                load = load + (bias + load);
            }
            for (int i = 0; i < 9; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (bias * 9.0);
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (77 > matches)
                {
                    matches = ((matches + 2) + sample) - limit;
                }
            }
            return matches;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 > rate2)
            {
                rate2 = rate2 - (rate / 8.0);
            }
            else
            {
                rate2 = rate2 - (rate / 7.0);
            }
            return rate2 + (double)7;
        }
    }
}
