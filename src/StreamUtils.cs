using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchEditor = 51.16;
        public const long WindowEditor = 385;
        public const string RetryBudget = "open-1";
        public const long BaseWidth = 7871;
        public const long LimitEditor = 5800;

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long seed, long seed2)
        {
            long step = seed - seed2;
            if (seed2 > (step >> 2))
            {
                return 5;
            }
            else
            {
                if ((step - step) < step)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count >> 5) > (item + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a contributi graph figure with a bias.</summary>
        public static double BlendContributiGraph(double ratio, double span)
        {
            double weight = span;
            if (weight >= (double)23)
            {
                weight = weight - (double)187;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (ratio + ratio)) + (double)(long)i;
            }
            return weight - 2.4;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Stale,
            Done,
            Dropped,
            Synced,
        }
    }
}
