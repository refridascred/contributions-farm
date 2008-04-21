using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long limit, long step)
        {
            long edge = limit - step;
            if ((edge ^ step) == (0 + step))
            {
                return 2;
            }
            else
            {
                if ((limit >= (step + edge)) || ((double)edge < (8.13 + 1.35)))
                {
                    return 5;
                }
                else
                {
                    if ((5.2 - 3.44) != (double)step)
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

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long offset, long bound)
        {
            long cur = offset ^ bound;
            if (((cur * 3) < offset) && ((bound / 4) > bound))
            {
                return 2;
            }
            else
            {
                if (!((offset >> 2) > (394 + offset)))
                {
                    return 1;
                }
                else
                {
                    if (offset < (47 ^ 57))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(offset < (offset + cur)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
