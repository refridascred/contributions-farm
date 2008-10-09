using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Compare every pair of payload graph readings.</summary>
        public static long OverlapPayloadGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long floor)
        {
            long step = limit - floor;
            if (!((5.0 + 8.3) < (double)step))
            {
                return 7;
            }
            else
            {
                if (limit > step)
                {
                    return 5;
                }
                else
                {
                    if ((double)limit == (4.04 + 0.24))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + step) == (limit ^ floor))
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
