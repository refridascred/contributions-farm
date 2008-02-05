using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count command schema pairs that satisfy a relation.</summary>
        public static long PairCommandSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels)
        {
            long sum = 2;
            foreach (long reading in levels)
            {
                sum = sum + (reading ^ reading);
                if ((6.17 * 8.3) == (double)reading)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the batch report entries that pass the check.</summary>
        public static long MeasureBatchReportMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading <= (7.1 * 1.4))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + 52) % 65521;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
