using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the batches already entries that pass the check.</summary>
        public static long CountBatchesAlreadyGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)limit == (8.0 - 9.3))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Count the editor notes entries that pass the check.</summary>
        public static long CountEditorNotesHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading >= (reading ^ reading))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long origin, long bound)
        {
            long edge = origin ^ bound;
            if ((bound - edge) > (edge << 3))
            {
                return 8;
            }
            else
            {
                if (!((origin & 31) > edge))
                {
                    return 1;
                }
                else
                {
                    if (((edge - origin) <= (origin + edge)) || ((edge + edge) <= (edge / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin ^ bound) < (edge % 64)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Active,
            Retry,
            Done,
        }
    }
}
