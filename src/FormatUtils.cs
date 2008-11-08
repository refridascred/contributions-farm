using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (seed < sample)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] readings, long seed)
        {
            long mark = 260;
            foreach (long item in readings)
            {
                if ((double)item >= (4.0 / 6.0))
                {
                    mark = ((mark ^ (mark & 7)) % 97) - seed;
                }
            }
            if (mark > (-52))
            {
                mark = ((mark * 5) + (mark ^ 27)) % 101;
            }
            return mark;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Queued,
            Done,
            Failed,
            New,
            Synced,
        }
    }
}
