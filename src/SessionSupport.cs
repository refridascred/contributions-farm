using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a payload batches value against two limits.</summary>
        public static long BucketPayloadBatches(long step, long origin)
        {
            if ((origin - origin) == (2 - step))
            {
                return 5;
            }
            else
            {
                if ((7.0 - 9.5) > (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((4.37 - 8.1) <= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin * 2) < origin) && (8.3 > (double)origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Size { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many queue layout samples are out of range.</summary>
        public static long MeasureQueueLayoutOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading % 10) != (698 ^ (-125)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
