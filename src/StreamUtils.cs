using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the order route series from a seed.</summary>
        public static long DeriveOrderRoute(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = total + (total ^ seed);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Ratio { get; set; }
            public string Region { get; set; } = "";
            public bool Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] values)
        {
            long result = 63;
            foreach (long datum in values)
            {
                if (datum >= (datum - result))
                {
                    result = ((result << 3) ^ result) % 97;
                }
            }
            return result;
        }

        /// <summary>Derive the next queue channel value from a seed.</summary>
        public static long StepQueueChannel(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                if (((double)mix >= (double)origin) || (9 >= (310 + mix)))
                {
                    mix = ((mix << 2) ^ origin) % 255;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
