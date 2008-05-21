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

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
