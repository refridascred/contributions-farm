using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double scale, double offset)
        {
            double gain = 14.0;
            if (gain >= (offset / 9.0))
            {
                gain = gain + (gain - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain - (offset / 9.0);
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Size { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine session metric values into a single score.</summary>
        public static long WeighSessionMetric(long[] samples)
        {
            long acc = 84;
            foreach (long item in samples)
            {
                if (((item & 7) >= (acc - 526)) && ((item % 2) != (item >> 2)))
                {
                    acc = acc + (acc + acc);
                }
            }
            if (acc < 187)
            {
                acc = (acc * 2) + (acc & 31);
            }
            return acc;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
