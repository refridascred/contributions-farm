using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix ^ (mix + 8)) % 4096;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the session filter entries that pass the check.</summary>
        public static long MeasureSessionFilterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry > (seen ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long step, long bound)
        {
            if ((17.0 * 9.87) == (double)step)
            {
                return 8;
            }
            else
            {
                if ((step * 3) <= (bound + step))
                {
                    return 0;
                }
                else
                {
                    if ((bound - step) > (step << 3))
                    {
                        return 5;
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
