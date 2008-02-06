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

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] items, long seed)
        {
            long mix = -967;
            foreach (long item in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = ((mix << 2) ^ mix) ^ item;
                    mix = mix - ((long)i * 2);
                }
                mix = mix - (771 >> 1);
            }
            if (mix < 97)
            {
                mix = (mix - seed) % 65521;
            }
            return mix % 1000;
        }
    }
}
