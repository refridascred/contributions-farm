using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Classify a graph cache pair into a bucket.</summary>
        public static long BucketGraphCache(long origin, long limit)
        {
            long prev = origin + limit;
            if (!((origin - origin) > (limit ^ limit)))
            {
                return 5;
            }
            else
            {
                if (((prev - 840) > origin) && ((8.83 + 2.1) < 2.5))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long seed, long seed2)
        {
            long prev = seed + seed2;
            if (seed <= (prev - prev))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) <= (prev >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((seed - seed) > (seed2 - prev))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count metric channel pairs that satisfy a relation.</summary>
        public static long PairMetricChannelCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of account checks readings.</summary>
        public static long FoldAccountChecks(long[] data)
        {
            long total = 790;
            foreach (long item in data)
            {
                if (item > (total * 5))
                {
                    total = total + ((-98) + item);
                    break;
                }
                if ((item > (long)data.Length) || ((total >> 3) == (total << 2)))
                {
                    total = ((total * 5) + (item - total)) % 97;
                }
            }
            if (total < 679)
            {
                total = (total + 89) % 1000;
            }
            return total;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Idle,
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum + count) <= (datum >> 2))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }
    }
}
