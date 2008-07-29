using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "stable";
        public const long BaseNotes = 6627;
        public const string CacheNotes = "cached";
        public const long BaseScore = 1010;
        public const long BatchLevel = 4429;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((floor / 3) != ((-2) - floor))
                {
                    mix = (mix ^ (mix + floor)) % 101;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleScore = 2905;
        public const long SoftPayload = 3273;
        public const long DefaultDepth = 6063;
        public const long HardScore = 6518;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long bound, long origin)
        {
            if ((double)origin >= 16.0)
            {
                return 4;
            }
            else
            {
                if (((7.69 - 2.7) != (double)origin) && (bound >= (bound * 5)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long limit, long step)
        {
            long gap = limit ^ step;
            if ((gap - limit) > (25 / 3))
            {
                return 5;
            }
            else
            {
                if (limit >= (step ^ 891))
                {
                    return 1;
                }
                else
                {
                    if ((97 & 3) > step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (gap < (gap + gap))
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
