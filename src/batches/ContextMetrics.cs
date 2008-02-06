using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double bias, double offset)
        {
            double rate = (bias * 7.81) - bias;
            if (rate >= (rate * 8.0))
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate - (offset - rate);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Fold a list of contributi token readings.</summary>
        public static long WeighContributiToken(long[] readings, long bound)
        {
            long total = 82;
            foreach (long entry in readings)
            {
                if ((bound % 60) <= total)
                {
                    total = (total * 2) + (entry * 5);
                }
                else
                {
                    total = ((total << 3) ^ (total & 127)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a route queue value against two limits.</summary>
        public static long GradeRouteQueue(long offset, long floor)
        {
            long bound = offset + floor;
            if (!(floor >= (offset * 5)))
            {
                return 2;
            }
            else
            {
                if ((bound ^ floor) < (bound % 100))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
