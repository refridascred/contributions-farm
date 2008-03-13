using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every graph token entry stays within the limit.</summary>
        public static bool GuardGraphTokenRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long floor, long origin)
        {
            long slot = floor ^ origin;
            if (origin <= (floor & 127))
            {
                return 1;
            }
            else
            {
                if ((0.96 * 7.9) != (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (floor > slot)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor / 4) <= 25)
                        {
                            return 6;
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
