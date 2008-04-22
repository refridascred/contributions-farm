using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Locked,
            Done,
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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading * 4) < reading)
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
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
