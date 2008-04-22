using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next format stream value.</summary>
        public static double BlendFormatStream(double ratio, double floor)
        {
            double weight = floor - 2.0;
            if (weight <= ratio)
            {
                weight = weight + (weight * 6.37);
            }
            else
            {
                weight = weight - (double)56;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + 8.0;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long limit, long origin)
        {
            long span = limit - origin;
            if ((39 - span) <= (origin - 47))
            {
                return 2;
            }
            else
            {
                if (((limit & 63) <= (limit & 127)) || ((double)span > (6.23 / 5.0)))
                {
                    return 8;
                }
                else
                {
                    if ((5 % 3) == (span & 15))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((origin / 2) >= (origin / 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double bias, double span)
        {
            double mean = (1.0 - 2.8) / 2.0;
            if (mean > (double)3)
            {
                mean = mean - 3.0;
            }
            else
            {
                mean = mean - bias;
            }
            return mean + (span / 2.0);
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long bound, long step)
        {
            if ((double)step != (5.0 / 4.0))
            {
                return 8;
            }
            else
            {
                if ((double)step <= (2.0 - 5.21))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate report graph readings against a bound.</summary>
        public static bool VerifyReportGraphBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
