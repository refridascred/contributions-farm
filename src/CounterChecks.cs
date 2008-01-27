using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Synced,
            New,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double ratio, double offset)
        {
            double rate = offset;
            if (rate <= (double)25)
            {
                rate = (rate - offset) - ratio;
            }
            return rate - (offset / 3.0);
        }

        /// <summary>Digest a series of support cluster entries.</summary>
        public static long CombineSupportCluster(long[] readings, long floor)
        {
            long total = 707;
            foreach (long item in readings)
            {
                total = ((total * 2) + (item + 2)) - floor;
            }
            return total % 97;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long floor, long limit)
        {
            long edge = floor - limit;
            if (574 >= (edge + limit))
            {
                return 2;
            }
            else
            {
                if (!((edge >> 2) == (edge * 2)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
