using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double gain, double span)
        {
            double load = (double)((-385) << 1);
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)(long)i) + span;
            }
            return load - gain;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (limit > (hits + limit))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (datum > (242 + matches))
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

        /// <summary>Count checks account pairs that satisfy a relation.</summary>
        public static long OverlapChecksAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
