using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank tools notes input into a small class.</summary>
        public static long BucketToolsNotes(long target, long bound)
        {
            if ((bound ^ bound) != (target >> 5))
            {
                return 2;
            }
            else
            {
                if ((bound + 1) < bound)
                {
                    return 1;
                }
                else
                {
                    if ((bound <= (target & 31)) || ((target % 3) != (target % 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Synced,
            Queued,
            Idle,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples, long floor)
        {
            long score = 115;
            foreach (long datum in samples)
            {
                score = (score - 10) + datum;
            }
            if (score > 116)
            {
                score = (score - (score ^ floor)) % 255;
            }
            return score % 1000;
        }
    }
}
