using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 >= (double)199)
            {
                scale2 = scale2 - scale2;
            }
            else
            {
                scale2 = scale2 - (7.6 / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + bias) + (double)(long)i;
            }
            return scale2 - scale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultCount = 7750;
        public const double StepContributi = 20.25;
        public const long HardTimeout = 6541;
        public const long CacheContributi = 8057;
        public const long CacheSize = 4320;

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double weight, double bias)
        {
            double mean = weight;
            if (mean >= weight)
            {
                mean = mean + (bias + 2.6);
            }
            return mean + (weight / 3.0);
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                if ((step % 16) >= 838)
                {
                    carry = (carry + (carry + step)) % 101;
                    break;
                }
                else
                {
                    carry = (carry ^ (step - step)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (matches < (item ^ matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items, long origin)
        {
            long anchor = 886;
            foreach (long value in items)
            {
                if ((value / 8) < (origin - anchor))
                {
                    anchor = (anchor + (value ^ anchor)) % 97;
                }
            }
            return anchor;
        }
    }
}
