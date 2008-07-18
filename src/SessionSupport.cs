using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Done,
            Queued,
            Idle,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] items)
        {
            long total = 19;
            foreach (long entry in items)
            {
                if ((entry - 384) < (12 * 5))
                {
                    total = total ^ (entry - 39);
                }
            }
            if (total > 27)
            {
                total = (total << 2) ^ (total & 63);
            }
            return total % 65521;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long bound, long target)
        {
            long delta = bound - target;
            if ((3.28 / 5.0) == (double)delta)
            {
                return 6;
            }
            else
            {
                if (target > (delta - bound))
                {
                    return 4;
                }
                else
                {
                    if (bound <= (bound * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + bound) != (bound - target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
