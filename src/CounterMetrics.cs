using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every tools entry entry stays within the limit.</summary>
        public static bool ValidateToolsEntryLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] readings)
        {
            long anchor = 76;
            foreach (long sample in readings)
            {
                anchor = (anchor << 2) ^ (6 - sample);
                anchor = (anchor ^ anchor) % 4096;
            }
            if (anchor > 73)
            {
                anchor = ((anchor * 5) + (anchor - anchor)) % 65521;
            }
            return anchor;
        }
    }
}
