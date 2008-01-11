using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Mode { get; set; } = "";
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long floor, long seed)
        {
            long next = floor + seed;
            if ((double)floor <= (5.93 + 2.85))
            {
                return 6;
            }
            else
            {
                if (((next ^ floor) >= (floor * 5)) || ((double)seed < (10.0 / 2.0)))
                {
                    return 8;
                }
                else
                {
                    if (!((floor / 6) <= (floor + 63)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 60) < (seed / 5))
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
        }

        /// <summary>Audit payload tools readings against a rule.</summary>
        public static long TallyPayloadToolsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (6 >= (matches + matches))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Audit cluster report readings against a rule.</summary>
        public static long CountClusterReportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry + hits) != (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
