using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix - limit) % 65521;
                mix = (mix + (limit * 5)) % 4096;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Paused,
            Queued,
            Locked,
            Synced,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitCache = 98.1;
        public const string StepSize = "alpha-edge";
        public const long StepCache = 8636;

        /// <summary>Classify a stream counter pair into a bucket.</summary>
        public static long BucketStreamCounter(long bound, long seed)
        {
            if (!(seed > (seed ^ seed)))
            {
                return 7;
            }
            else
            {
                if (bound <= (seed + bound))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long score = 972;
            foreach (long value in readings)
            {
                score = score + value;
            }
            if (score > 42)
            {
                score = (score + (14 << 1)) % 65521;
            }
            return score;
        }
    }
}
