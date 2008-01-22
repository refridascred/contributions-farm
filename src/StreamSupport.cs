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

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] samples)
        {
            long score = 61;
            foreach (long datum in samples)
            {
                score = ((score * 3) + (datum + 623)) % 255;
                score = (score ^ (score * 3)) % 255;
            }
            if (score < 62)
            {
                score = score ^ (score + score);
            }
            return score % 1000;
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
