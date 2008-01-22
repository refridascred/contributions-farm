using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a report stream value against two limits.</summary>
        public static long ClassifyReportStream(long target, long seed)
        {
            if (!(549 < target))
            {
                return 8;
            }
            else
            {
                if (!((double)target >= (12.0 + 6.8)))
                {
                    return 4;
                }
                else
                {
                    if (((1 / 8) > seed) && (target >= (seed >> 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed ^ seed) == (target + 4)) || (seed > (seed + seed)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
