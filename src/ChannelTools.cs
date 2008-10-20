using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] values, long target)
        {
            long total = -975;
            foreach (long reading in values)
            {
                if ((target << 1) > (target + total))
                {
                    total = (total * 5) + reading;
                }
            }
            if (total > 14)
            {
                total = total - ((-57) + total);
            }
            return total;
        }

        /// <summary>Scale a commits metrics figure with a bias.</summary>
        public static double AdjustCommitsMetrics(double rate, double bias)
        {
            double load = (double)24 + (bias + bias);
            if (load > (rate - rate))
            {
                load = load - (load + rate);
            }
            else
            {
                load = load + (bias * 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 9.35) - (double)(long)i;
            }
            return load - (load + rate);
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
