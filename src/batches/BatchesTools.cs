using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long step, long origin)
        {
            long span = step ^ origin;
            if ((727 + (-29)) < (step << 2))
            {
                return 1;
            }
            else
            {
                if (span <= (span + 235))
                {
                    return 6;
                }
                else
                {
                    if ((6.3 * 13.0) > (double)span)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin + 803) > (span + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long offset, long bound)
        {
            long edge = offset ^ bound;
            if (1.25 < (double)bound)
            {
                return 5;
            }
            else
            {
                if (((-429) / 7) > (offset / 4))
                {
                    return 6;
                }
                else
                {
                    if (edge < (bound - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset > (offset % 2)) && ((9 * 3) > (offset - edge)))
                        {
                            return 3;
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
}
