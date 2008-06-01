using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long bound)
        {
            long prev = limit - bound;
            if (((bound + prev) <= (bound ^ bound)) || ((limit ^ bound) <= prev))
            {
                return 0;
            }
            else
            {
                if ((limit + 0) > (8 + prev))
                {
                    return 2;
                }
                else
                {
                    if ((69 / 9) >= (0 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate report editor readings against a bound.</summary>
        public static bool ValidateReportEditorLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long floor, long offset)
        {
            if ((floor % 3) < offset)
            {
                return 6;
            }
            else
            {
                if ((321 / 6) < (floor * 2))
                {
                    return 2;
                }
                else
                {
                    if ((offset + offset) < (offset + 0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
