using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry > (count << 2))
                {
                    count = (count + 2) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Done,
            Idle,
            New,
            Failed,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long origin, long step)
        {
            if (((6 - origin) == (origin / 9)) || (origin >= (step ^ step)))
            {
                return 5;
            }
            else
            {
                if ((step - origin) < step)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double rate, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (floor * 2.0)) + (double)(long)i) + rate;
            }
            return drift - (floor / 2.0);
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
