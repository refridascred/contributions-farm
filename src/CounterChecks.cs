using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a channel context counter forward.</summary>
        public static long SeriesChannelContext(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (((score << 2) ^ ((long)i / 4)) % 101) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the profile order entries that pass the check.</summary>
        public static long AuditProfileOrderOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((252 + tally) >= (tally ^ tally)) || (tally >= sample))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] samples)
        {
            long anchor = 5;
            foreach (long entry in samples)
            {
                if ((entry - anchor) < entry)
                {
                    anchor = ((anchor << 3) ^ entry) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream contributi readings against a rule.</summary>
        public static long MeasureStreamContributiMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((limit + (-58)) == (limit << 2)) || ((cell ^ 63) != (limit ^ limit)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
