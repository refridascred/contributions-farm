using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((entry + entry) >= 69) || ((entry % 100) >= entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long limit, long limit2)
        {
            long span = limit ^ limit2;
            if (!((span << 2) < span))
            {
                return 7;
            }
            else
            {
                if (0.65 < (double)span)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit <= (9.5 + 7.56))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.0 - 1.78) > (double)span)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate layout window samples.</summary>
        public static long TallyLayoutWindow(long[] samples)
        {
            long anchor = 578;
            foreach (long value in samples)
            {
                anchor = ((anchor + anchor) % 101) - value;
                anchor = (anchor - 2) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Region { get; set; }
            public double Mode { get; set; }
            public double Stamp { get; set; }
        }
    }
}
