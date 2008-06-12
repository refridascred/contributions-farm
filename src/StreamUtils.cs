using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Queued,
            Retry,
            Active,
            Done,
            Pending,
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)offset != (6.87 * 15.0))
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long bound, long step)
        {
            if (step > (step << 2))
            {
                return 1;
            }
            else
            {
                if (((bound + bound) >= (bound - step)) || ((step + bound) >= bound))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up payload cluster samples.</summary>
        public static long ComparePayloadClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
