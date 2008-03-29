using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Count { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] series)
        {
            long result = -948;
            foreach (long datum in series)
            {
                result = (result * 3) + (datum / 5);
                if ((datum + datum) != (datum >> 1))
                {
                    break;
                }
            }
            if (result < 984)
            {
                result = result + result;
            }
            return result % 65521;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits - hits) > reading)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
