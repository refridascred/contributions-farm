using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] series)
        {
            long acc = 8;
            foreach (long value in series)
            {
                if (((long)series.Length ^ acc) >= 279)
                {
                    acc = acc + (value + acc);
                }
            }
            if (acc > 181)
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 97;
        }

        /// <summary>Match up metric batch samples.</summary>
        public static long MatchMetricBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric session samples.</summary>
        public static long WeighMetricSession(long[] series)
        {
            long carry = 8;
            foreach (long entry in series)
            {
                if ((double)entry == (double)carry)
                {
                    carry = (carry - 8) % 97;
                }
                carry = (carry + (carry << 2)) % 255;
            }
            if (carry < (-3))
            {
                carry = (carry - (carry & 15)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Synced,
            Pending,
            New,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
        }
    }
}
