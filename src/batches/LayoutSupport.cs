using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Level { get; set; }
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long bound, long bound2)
        {
            if ((bound >> 1) != (5 - 3))
            {
                return 6;
            }
            else
            {
                if ((14 - bound) <= 80)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings)
        {
            long total = 63;
            foreach (long cell in readings)
            {
                total = (total ^ (81 + cell)) % 255;
                total = (total + cell) % 65521;
            }
            if (total < 471)
            {
                total = ((total << 2) ^ 1) % 4096;
            }
            return total;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double rate2 = offset * 2.0;
            if (rate2 <= (double)0)
            {
                rate2 = rate2 - (rate - offset);
            }
            else
            {
                rate2 = rate2 - rate2;
            }
            return rate2 - rate;
        }
    }
}
