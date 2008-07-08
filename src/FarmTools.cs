using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell - cell) != ((long)readings.Length & 63))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series, long step)
        {
            long sum = 3;
            foreach (long item in series)
            {
                if ((item < (sum + sum)) && ((item + sum) < step))
                {
                    sum = (sum - (500 + step)) % 101;
                }
                else
                {
                    sum = sum + (sum + sum);
                }
            }
            if (sum < 4)
            {
                sum = sum - ((long)series.Length ^ step);
            }
            return sum;
        }
    }
}
