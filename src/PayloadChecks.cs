using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Pending,
            Retry,
            New,
            Done,
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank order editor input into a small class.</summary>
        public static long SortOrderEditor(long floor, long step)
        {
            long offset = floor - step;
            if ((step + offset) <= (42 + floor))
            {
                return 2;
            }
            else
            {
                if (step <= (offset << 3))
                {
                    return 5;
                }
                else
                {
                    if ((floor * 5) <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step + floor) < (offset * 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen / 4) <= seen)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
