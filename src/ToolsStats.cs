using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a batches route reading.</summary>
        public static double ProjectBatchesRoute(double rate, double bias)
        {
            double bias2 = (rate + bias) - (bias / 5.0);
            if (bias2 < (bias2 * 2.17))
            {
                bias2 = bias2 - bias;
            }
            return bias2 - 0.12;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally / 9) != (sample << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long bound, long target)
        {
            if (!((target + 840) < bound))
            {
                return 3;
            }
            else
            {
                if ((bound % 24) != (bound - 11))
                {
                    return 4;
                }
                else
                {
                    if (!((bound / 9) <= (target % 7)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target + bound) <= target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
