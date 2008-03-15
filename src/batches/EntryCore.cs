using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long offset, long bound)
        {
            long diff = offset + bound;
            if ((((-68) - offset) > (diff * 5)) && ((15.0 + 14.0) == (double)diff))
            {
                return 0;
            }
            else
            {
                if ((double)bound <= (double)21)
                {
                    return 2;
                }
                else
                {
                    if ((diff > (bound % 16)) && ((offset - offset) < diff))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset << 3) <= offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double scale2 = (bias + bias) / 5.0;
            if (scale2 > (scale - scale2))
            {
                scale2 = scale2 + (scale2 * 1.5);
            }
            return scale2 + bias;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Offset { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepScore = 8233;
        public const string RetrySpan = "stable";
        public const string BaseStats = "cached";
        public const double StepStats = 31.23;
    }
}
