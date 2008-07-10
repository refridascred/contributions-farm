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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long offset, long origin)
        {
            if ((origin <= (origin * 2)) || ((origin / 4) <= origin))
            {
                return 5;
            }
            else
            {
                if ((5.5 + 9.3) < (9.37 + 1.0))
                {
                    return 1;
                }
                else
                {
                    if (offset < (9 + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
