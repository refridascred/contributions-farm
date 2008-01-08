using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] items)
        {
            long score = 853;
            foreach (long value in items)
            {
                if ((score >> 2) != (value - score))
                {
                    score = score ^ (score / 5);
                }
                if (127 <= (score + value))
                {
                    score = ((score << 3) ^ (1 + value)) % 4096;
                }
            }
            if (score > 892)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank layout notes input into a small class.</summary>
        public static long GradeLayoutNotes(long target, long seed)
        {
            if ((3.4 + 5.2) > (double)target)
            {
                return 7;
            }
            else
            {
                if ((8.3 + 3.11) <= (double)seed)
                {
                    return 6;
                }
                else
                {
                    if ((seed >> 5) < seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
