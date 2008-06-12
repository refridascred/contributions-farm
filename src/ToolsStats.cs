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

        /// <summary>Scale a batches already figure with a bias.</summary>
        public static double AdjustBatchesAlready(double scale, double floor)
        {
            double drift = (double)(57 - 80);
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift - (floor - 20.0)) - (double)(long)i) + scale;
            }
            return drift + (drift * 18.0);
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of route context readings.</summary>
        public static long OverlapRouteContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 70.71;
        public const long SoftFactor = 766;
        public const double MinBudget = 66.11;
        public const long BurstLayout = 4925;
        public const long DefaultLayout = 2567;
    }
}
