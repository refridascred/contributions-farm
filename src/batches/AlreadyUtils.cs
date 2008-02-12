using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many counter metric samples are out of range.</summary>
        public static long AuditCounterMetricOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((6 ^ cell) > (cell + cell)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream layout readings.</summary>
        public static long TallyStreamLayout(long[] samples, long target)
        {
            long acc = 5;
            foreach (long datum in samples)
            {
                long span = datum;
                acc = acc ^ (span ^ datum);
                if ((target ^ acc) < (datum - datum))
                {
                    acc = ((acc << 3) ^ (target * 3)) % 1000;
                }
            }
            return acc % 4096;
        }
    }
}
