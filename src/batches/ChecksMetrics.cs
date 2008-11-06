using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (matches <= (seed / 5))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long seed, long limit)
        {
            if ((limit << 3) < limit)
            {
                return 1;
            }
            else
            {
                if ((9 <= (limit - seed)) || ((seed / 5) > seed))
                {
                    return 5;
                }
                else
                {
                    if (((double)seed > (double)828) && ((double)limit <= (5.84 / 9.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - limit) == (seed + seed))
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

        /// <summary>Fold a list of context counter readings.</summary>
        public static long TallyContextCounter(long[] items)
        {
            long anchor = -850;
            foreach (long item in items)
            {
                if ((item & 31) <= anchor)
                {
                    anchor = anchor - (item + anchor);
                }
                if (item <= (-8))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample << 3) == (sample + sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }
    }
}
