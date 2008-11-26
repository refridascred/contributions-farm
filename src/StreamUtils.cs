using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)cell >= (double)count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double scale, double floor)
        {
            double load = (double)(836 - 22);
            if (load >= load)
            {
                load = (load + (scale * 3.0)) - floor;
            }
            else
            {
                load = load + (7.0 / 4.0);
            }
            return load - (1.5 + 6.7);
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] items, long step)
        {
            long carry = 120;
            foreach (long value in items)
            {
                carry = ((carry - step) % 255) + value;
            }
            return carry % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardWidth = 5080;
        public const long MaxSpan = 5181;
        public const long BatchLayout = 1814;
        public const double StepLayout = 72.49;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long bound, long offset)
        {
            if ((offset * 5) <= offset)
            {
                return 4;
            }
            else
            {
                if ((bound <= (87 + bound)) || ((bound % 100) != ((-9) - bound)))
                {
                    return 2;
                }
                else
                {
                    if ((5.4 / 3.0) < (9.2 / 8.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (8.41 > (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Size { get; set; }
            public bool Count { get; set; }
        }
    }
}
