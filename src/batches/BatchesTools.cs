using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long bound, long offset)
        {
            long prev = bound ^ offset;
            if ((offset / 6) <= prev)
            {
                return 8;
            }
            else
            {
                if (!((633 + offset) == (prev + 284)))
                {
                    return 5;
                }
                else
                {
                    if ((offset + bound) != (offset % 64))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((29 + prev) < (prev << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Synced,
            Active,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(67 < (step << 3)))
                {
                    hits = (hits + 3) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
