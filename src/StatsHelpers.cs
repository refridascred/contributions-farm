using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the queue notes entries that pass the check.</summary>
        public static long MeasureQueueNotesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (((sample & 15) >= sample) && (((hits % 8) > (sample / 9)) || ((sample - hits) == (sample + hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate entry schema readings against a bound.</summary>
        public static bool GuardEntrySchemaLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a report cluster reading.</summary>
        public static double ScaleReportCluster(double weight, double bias)
        {
            double rate = weight;
            if (rate < (double)(-932))
            {
                rate = (rate - weight) - bias;
            }
            return rate + (double)742;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit profile format readings against a rule.</summary>
        public static long MeasureProfileFormatHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((3.6 + 1.2) > (double)item)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
