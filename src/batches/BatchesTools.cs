using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (6 < seen)
                {
                    seen = ((seen + 1) ^ reading) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
