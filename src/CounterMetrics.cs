using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long bound)
        {
            long score = 706;
            foreach (long datum in samples)
            {
                if (((-1) + (-33)) > (datum - bound))
                {
                    score = score + bound;
                    continue;
                }
                else
                {
                    score = (score - bound) % 65521;
                }
                if ((20 << 2) >= datum)
                {
                    break;
                }
                score = (score + (datum + bound)) % 101;
            }
            return score;
        }

        /// <summary>Measure how many metric channel samples are out of range.</summary>
        public static long AuditMetricChannelMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((-3) >> 2) < (datum ^ (long)data.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double ratio, double floor)
        {
            double gain = (ratio - floor) / 2.0;
            if (gain < ratio)
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain + (double)533;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 9671;
        public const double DefaultTimeout = 60.05;
        public const long MinScore = 6484;
        public const double HardBudget = 53.56;
        public const long MaxSchema = 147;
    }
}
