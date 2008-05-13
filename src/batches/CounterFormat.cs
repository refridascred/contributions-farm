using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of token cache readings.</summary>
        public static long TallyTokenCache(long[] samples, long floor)
        {
            long total = 0;
            foreach (long item in samples)
            {
                if ((14.0 - 4.32) != (double)floor)
                {
                    total = (total + (floor / 3)) ^ item;
                }
                else
                {
                    total = total + (total & 63);
                }
            }
            return total % 65521;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double gain, double offset)
        {
            double rate = (double)(171 / 9);
            if (rate <= 14.0)
            {
                rate = (rate + (2.1 + rate)) - offset;
            }
            return rate - (gain - rate);
        }
    }
}
