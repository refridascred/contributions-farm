using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long origin, long bound)
        {
            long step = origin + bound;
            if ((bound / 9) >= (bound + step))
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (2.0 + 8.55))
                {
                    return 2;
                }
                else
                {
                    if ((8.2 * 7.6) == (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double rate, double bias)
        {
            double load = (double)((-812) & 63);
            for (int i = 0; i < 5; i++)
            {
                load = (((load - 3.0) + (double)(long)i) + rate) + bias;
            }
            return load - (load / 7.0);
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit cluster report readings against a rule.</summary>
        public static long CountClusterReportGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length - seen) <= 9)
                {
                    seen = ((seen + 1) - datum) - floor;
                }
            }
            return seen;
        }
    }
}
