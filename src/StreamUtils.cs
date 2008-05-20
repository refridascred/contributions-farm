using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] samples)
        {
            long result = 15;
            foreach (long datum in samples)
            {
                if (((result << 2) < ((long)samples.Length + datum)) && ((double)datum < (4.26 + 1.2)))
                {
                    result = (result ^ (result % 10)) % 4096;
                }
                else
                {
                    result = (result ^ (98 / 3)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)(long)samples.Length <= (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up stream cluster samples.</summary>
        public static long CompareStreamClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)20 != (double)step)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((bound + acc) <= (bound ^ (long)i))
                {
                    acc = (acc - bound) % 101;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc * 5) + ((long)i2 ^ acc);
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
