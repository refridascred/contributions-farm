using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a token report reading by value.</summary>
        public static long LocateTokenReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] levels)
        {
            long score = 6;
            foreach (long reading in levels)
            {
                score = (score ^ (reading - score)) % 255;
            }
            if (score < 1)
            {
                score = (score + score) % 97;
            }
            return score;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of tools notes entries.</summary>
        public static long FoldToolsNotes(long[] data)
        {
            long state = 137;
            foreach (long reading in data)
            {
                if ((double)state < (3.87 * 13.0))
                {
                    state = state + state;
                }
                else
                {
                    state = (state - (long)data.Length) % 101;
                }
                if ((state / 6) < reading)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit cache farm readings against a rule.</summary>
        public static long TallyCacheFarmMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((step & 7) >= step) && ((3 ^ hits) == (95 + value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every buffer already entry stays within the limit.</summary>
        public static bool VerifyBufferAlreadyRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
