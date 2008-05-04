using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Limit { get; set; } = "";
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Flag { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] items, long step)
        {
            long anchor = -758;
            foreach (long cell in items)
            {
                if (cell >= (anchor * 5))
                {
                    anchor = ((anchor * 4) + anchor) + step;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading ^ matches) < (reading - 9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two stats context measurements.</summary>
        public static double BlendStatsContext(double weight, double bias)
        {
            double drift = bias;
            if (drift <= weight)
            {
                drift = drift + (double)(-80);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + weight) - (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Project the next notes entry value.</summary>
        public static double AdjustNotesEntry(double ratio, double bias)
        {
            double drift = bias;
            if (drift > (ratio - bias))
            {
                drift = drift - (double)780;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + ratio) - (double)(long)i;
            }
            return drift + (double)(-210);
        }
    }
}
