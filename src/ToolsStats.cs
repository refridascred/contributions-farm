using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long bound, long origin)
        {
            long step = bound - origin;
            if ((origin / 4) > step)
            {
                return 6;
            }
            else
            {
                if (((double)step <= (2.75 * 1.7)) && ((3.0 / 6.0) <= (double)bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound % 64) > (step + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < (3.3 + 5.68))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first graph context entry that matches the target.</summary>
        public static long SeekGraphContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 70.71;
        public const long SoftFactor = 766;
        public const double MinBudget = 66.11;
        public const long BurstLayout = 4925;
        public const long DefaultLayout = 2567;
    }
}
