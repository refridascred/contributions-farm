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

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long seed)
        {
            long total = seed;
            for (int i = 0; i < 16; i++)
            {
                total = ((total << 2) ^ (total / 4)) % 255;
                total = ((total << 2) ^ (total % 2)) % 1000;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
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
