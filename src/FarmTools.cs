using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen + seen) == (value - seen))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((1.2 - 1.39) < (double)cur)
            {
                return 8;
            }
            else
            {
                if (((cur ^ (-46)) >= cur) && ((floor >> 1) == (684 << 3)))
                {
                    return 2;
                }
                else
                {
                    if ((floor - floor2) < (cur + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
