using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long offset, long step)
        {
            long prev = offset + step;
            if (step >= (6 & 255))
            {
                return 6;
            }
            else
            {
                if (offset > (step * 2))
                {
                    return 0;
                }
                else
                {
                    if (((offset - offset) == (prev / 3)) && ((prev - prev) > 144))
                    {
                        return 2;
                    }
                    else
                    {
                        if (step <= offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Active,
            Pending,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Active,
            Pending,
            Failed,
            Ready,
        }
    }
}
