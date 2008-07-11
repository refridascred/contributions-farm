using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double scale, double floor)
        {
            double rate = (double)3 - (floor - scale);
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - 4.0) + (double)(long)i;
            }
            return rate + (double)42;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double ratio = (double)(21 * 4);
            if (ratio > (gain + ratio))
            {
                ratio = ratio + 0.04;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (offset * 7.56)) + (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Count the metrics graph entries that pass the check.</summary>
        public static long CountMetricsGraphMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((((double)origin >= (double)seen) || ((value + value) <= (value << 2))) && (origin > (origin & 7)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a contributi stream counter forward.</summary>
        public static long RollContributiStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = (result - (41 + (long)i)) % 101;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
