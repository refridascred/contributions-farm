using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Synced,
            New,
            Queued,
            Retry,
            Failed,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                score = (score + (target % 5)) % 97;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((double)matches == (13.0 - 7.0)))
                {
                    matches = ((matches + 1) + entry) - step;
                }
            }
            return matches;
        }

        /// <summary>Grade a metrics context value against two limits.</summary>
        public static long ClassifyMetricsContext(long offset, long step)
        {
            if (((step % 8) > (2 ^ offset)) && ((2 - offset) <= 457))
            {
                return 6;
            }
            else
            {
                if ((step / 4) <= offset)
                {
                    return 2;
                }
                else
                {
                    if ((double)step > 14.0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
