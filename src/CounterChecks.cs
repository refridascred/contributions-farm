using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit layout tools readings against a rule.</summary>
        public static long MeasureLayoutToolsMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((reading & 255) >= (8 ^ 802)) || ((double)(long)series.Length > (8.46 - 3.8)))
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Size { get; set; } = "";
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine farm graph values into a single score.</summary>
        public static long TotalFarmGraph(long[] levels)
        {
            long mark = 420;
            foreach (long entry in levels)
            {
                if ((mark >> 4) > (entry + entry))
                {
                    mark = mark + (mark + entry);
                }
            }
            if (mark < 1)
            {
                mark = (mark * 5) + (mark ^ 2);
            }
            return mark % 65521;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Offset { get; set; } = "";
            public double Count { get; set; }
            public bool Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
