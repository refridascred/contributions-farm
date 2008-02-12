using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = sum + (3 >> 3);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public string Count { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Blend two contributi already measurements.</summary>
        public static double SmoothContributiAlready(double weight, double floor)
        {
            double weight2 = (floor - floor) / 4.0;
            return weight2 + (weight + weight);
        }

        /// <summary>Validate metric farm readings against a bound.</summary>
        public static bool VerifyMetricFarmRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long seed, long seed2)
        {
            long offset = seed - seed2;
            if (seed2 <= (seed2 << 2))
            {
                return 8;
            }
            else
            {
                if ((seed2 << 3) > offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset + seed2) > seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)739 <= (double)seed2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
