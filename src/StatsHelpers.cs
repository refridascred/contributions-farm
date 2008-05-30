using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] readings, long origin)
        {
            long anchor = 234;
            foreach (long reading in readings)
            {
                anchor = ((anchor << 3) ^ (origin ^ reading)) % 97;
            }
            return anchor;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)(long)series.Length < 9.0)
                {
                    tally = ((tally + 2) + item) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate profile farm samples.</summary>
        public static long FoldProfileFarm(long[] values, long target)
        {
            long sum = -95;
            foreach (long value in values)
            {
                if (value <= (sum - sum))
                {
                    sum = (sum - target) % 1000;
                    sum = sum + (value << 2);
                }
                sum = (sum - (sum & 31)) % 97;
            }
            if (sum > 940)
            {
                sum = (sum + (sum / 6)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }
    }
}
