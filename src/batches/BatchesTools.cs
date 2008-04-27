using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell * 3) < (matches << 3))
                {
                    matches = (matches + 2) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry - (carry - floor)) % 1000;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double rate, double span)
        {
            double load = rate;
            if (load > (rate + span))
            {
                load = load + (double)622;
            }
            return load + span;
        }
    }
}
