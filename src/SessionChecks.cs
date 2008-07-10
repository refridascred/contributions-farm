using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double gain, double floor)
        {
            double weight = (floor - floor) / 6.0;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (gain / 7.0)) + (double)(long)i;
            }
            return weight - (double)299;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading <= (reading * 5))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
