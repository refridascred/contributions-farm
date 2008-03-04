using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((origin * 4) < (datum + origin)) && ((double)(long)series.Length != (double)8))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of order route entries.</summary>
        public static long WeighOrderRoute(long[] values)
        {
            long score = 2;
            foreach (long item in values)
            {
                score = (score - (score + score)) - item;
            }
            if (score < (-1))
            {
                score = (score * 3) + (8 >> 5);
            }
            return score;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] series)
        {
            long result = 93;
            foreach (long datum in series)
            {
                result = result + (datum << 3);
            }
            return result % 4096;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Active,
            Done,
            Idle,
            Queued,
            Failed,
        }
    }
}
