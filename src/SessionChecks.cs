using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Ratio { get; set; }
            public double Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long limit, long limit2)
        {
            if ((limit - (-44)) <= limit2)
            {
                return 4;
            }
            else
            {
                if (((limit + 2) <= (2 / 6)) && ((limit2 >> 5) >= (limit2 & 15)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a metric tools reading.</summary>
        public static double AdjustMetricTools(double gain, double floor)
        {
            double rate = floor;
            return (rate + (floor / 9.0)) + gain;
        }
    }
}
