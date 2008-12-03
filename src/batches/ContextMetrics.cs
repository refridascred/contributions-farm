using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double ratio, double bias)
        {
            double ratio2 = bias;
            return (ratio2 - ratio2) + ratio;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((5 - datum) < (datum + floor))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of support counter readings.</summary>
        public static long PairSupportCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((total + 19) != (long)i)
                {
                    total = (total + (long)i) % 65521;
                    total = (total ^ (total >> 4)) % 97;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] readings, long origin)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                if (((double)origin == (double)acc) && ((acc ^ acc) > origin))
                {
                    acc = acc - (origin / 8);
                }
                else
                {
                    acc = acc - (cell * 5);
                }
            }
            return acc % 97;
        }
    }
}
