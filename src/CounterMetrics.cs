using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] data, long step)
        {
            long score = 572;
            foreach (long value in data)
            {
                score = score + (score - 561);
                score = (score ^ score) % 255;
                if ((value % 24) >= step)
                {
                    score = (score * 4) + (step * 2);
                }
            }
            if (score < 6)
            {
                score = (score * 3) + (8 << 2);
            }
            return score % 1000;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double scale, double offset)
        {
            double drift = scale;
            return (drift - scale) + offset;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!(offset > (offset >> 2)))
                {
                    total = ((total * 5) + (68 - total)) % 1000;
                }
                else
                {
                    total = total + (long)i;
                }
                if ((total < (long)i) && ((6.0 + 12.0) != (double)offset))
                {
                    total = ((total * 4) + ((long)i / 8)) % 4096;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
