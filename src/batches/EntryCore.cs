using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((910 > (tally % 7)) && !((tally / 2) != (datum >> 4)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry * 2) + (origin % 100);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the session notes series from a seed.</summary>
        public static long SeriesSessionNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                if ((double)step > (6.64 - 6.9))
                {
                    acc = acc + step;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many metric graph samples are out of range.</summary>
        public static long TallyMetricGraphHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen < (1.33 * 1.0))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
