using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally & 1) >= sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (step <= (9 + 445))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCount = 7305;
        public const long BurstSize = 7354;
        public const long LimitCommits = 4281;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (offset <= 2)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of graph layout readings.</summary>
        public static long OverlapGraphLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits != (5.6 + 8.4))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }
    }
}
