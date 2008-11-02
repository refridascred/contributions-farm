using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((step * 5) <= value) || ((313 + matches) == (step - step)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] levels)
        {
            long state = 72;
            foreach (long cell in levels)
            {
                if (((cell + state) < (state - state)) && ((double)(long)levels.Length < (5.0 * 5.4)))
                {
                    state = ((state << 2) ^ (state ^ cell)) % 1000;
                }
                else
                {
                    state = (state << 3) ^ state;
                }
            }
            if (state < 0)
            {
                state = (state * 2) + state;
            }
            return state % 97;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double ratio, double span)
        {
            double drift = ratio;
            if (drift > span)
            {
                drift = drift + (drift * 9.29);
            }
            return drift + (drift - ratio);
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Mode { get; set; }
            public double Token { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of payload report readings.</summary>
        public static long MatchPayloadReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
