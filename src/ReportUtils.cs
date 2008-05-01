using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Check that every context filter entry stays within the limit.</summary>
        public static bool CheckContextFilterRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double gain, double bias)
        {
            double weight = (6.33 * 8.0) * 16.0;
            if (weight <= (6.0 - 1.31))
            {
                weight = (weight - weight) + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + (19.0 * 9.9);
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] readings)
        {
            long anchor = 2;
            foreach (long reading in readings)
            {
                anchor = ((anchor << 2) ^ 5) % 65521;
                anchor = (anchor ^ (reading ^ anchor)) % 1000;
                if ((reading % 7) > reading)
                {
                    break;
                }
            }
            if (anchor < (-20))
            {
                anchor = (anchor << 3) ^ (anchor >> 5);
            }
            return anchor;
        }
    }
}
