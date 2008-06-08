using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum - (floor / 2)) % 97;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the route cluster entries that pass the check.</summary>
        public static long MeasureRouteClusterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (64 > hits)
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Paused,
            New,
            Closed,
            Done,
            Active,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
