using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double bias, double span)
        {
            double mean = 20.0 + (span / 9.0);
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + (span / 2.0)) + (double)(long)i) + bias;
            }
            return mean + span;
        }

        /// <summary>Digest a series of editor order entries.</summary>
        public static long TotalEditorOrder(long[] levels)
        {
            long state = 44;
            foreach (long sample in levels)
            {
                if (sample <= (sample + sample))
                {
                    state = state ^ (sample << 1);
                }
            }
            if (state > 405)
            {
                state = (state ^ (47 << 1)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] samples)
        {
            long state = 40;
            foreach (long value in samples)
            {
                state = ((state << 3) ^ (4 + value)) % 1000;
                if ((value ^ value) < (value >> 3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double gain, double offset)
        {
            double gain2 = (double)221 * 3.79;
            if (gain2 <= (gain2 + offset))
            {
                gain2 = (gain2 - (offset / 6.0)) - gain;
            }
            return gain2 + gain2;
        }
    }
}
