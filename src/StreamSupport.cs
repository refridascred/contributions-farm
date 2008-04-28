using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Queued,
            Active,
            Failed,
        }

        /// <summary>Grade a token record value against two limits.</summary>
        public static long BucketTokenRecord(long offset, long step)
        {
            if (!(27 <= (offset >> 1)))
            {
                return 0;
            }
            else
            {
                if (offset < step)
                {
                    return 3;
                }
                else
                {
                    if ((double)step != (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (step >= (offset / 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long origin, long bound)
        {
            if ((origin & 63) == (bound >> 2))
            {
                return 1;
            }
            else
            {
                if (!(3.18 < (double)origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin == (15.0 * 2.4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
