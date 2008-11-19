using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftCluster = 80.12;
        public const long StepSpan = 2633;
        public const string WindowCluster = "legacy";
        public const long DefaultScore = 280;

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double rate, double floor)
        {
            double mean = (double)74 / 5.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (rate * 6.62)) - (double)(long)i;
            }
            return mean + (floor / 5.0);
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long target)
        {
            if (origin < 994)
            {
                return 2;
            }
            else
            {
                if ((origin * 5) < (origin + target))
                {
                    return 8;
                }
                else
                {
                    if ((target & 1) <= (origin - 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.0 + 8.95) == (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
