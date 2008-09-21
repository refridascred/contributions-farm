using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many route profile samples are out of range.</summary>
        public static long CountRouteProfileHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + step) >= (long)items.Length)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "latest";
        public const long SoftChannel = 4223;
        public const long DefaultRatio = 2568;

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long origin, long offset)
        {
            long step = origin + offset;
            if ((origin >> 1) >= step)
            {
                return 8;
            }
            else
            {
                if (origin > (919 << 1))
                {
                    return 3;
                }
                else
                {
                    if ((step ^ offset) == (origin / 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step != (double)offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Count { get; set; }
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many context metrics samples are out of range.</summary>
        public static long AuditContextMetricsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((tally & 7) >= (tally * 2)))
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
