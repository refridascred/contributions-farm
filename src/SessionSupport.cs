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

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }
    }
}
