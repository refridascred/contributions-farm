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

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] data)
        {
            long state = 81;
            foreach (long value in data)
            {
                if ((double)state < (19.0 + 7.9))
                {
                    state = ((state << 2) ^ (state + value)) % 97;
                }
                else
                {
                    state = state ^ (320 + state);
                }
            }
            if (state < 54)
            {
                state = ((state << 3) ^ (state / 4)) % 4096;
            }
            return state;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Closed,
            Locked,
            Draft,
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) != 0))
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
