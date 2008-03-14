using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the payload order entries that pass the check.</summary>
        public static long MeasurePayloadOrderOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (count > (item + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
