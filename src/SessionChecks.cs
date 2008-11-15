using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double rate, double offset)
        {
            double gain = (rate - rate) + (rate * 8.96);
            if (gain > (gain - rate))
            {
                gain = (gain - (gain + 3.6)) - offset;
            }
            return gain + 5.4;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] values, long floor)
        {
            long result = -102;
            foreach (long entry in values)
            {
                if (((double)7 <= (double)(long)values.Length) || ((2.0 * 15.0) > (double)(long)values.Length))
                {
                    result = result - (floor * 3);
                }
                if ((entry >> 4) <= entry)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Check that every layout report entry stays within the limit.</summary>
        public static bool VerifyLayoutReportRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc << 3) ^ acc;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
