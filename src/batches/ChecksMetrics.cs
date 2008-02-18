using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (seen <= (seen >> 1))
                {
                    seen = ((seen + 3) + item) - limit;
                }
            }
            return seen;
        }

        /// <summary>Adjust a queue profile reading.</summary>
        public static double ScaleQueueProfile(double scale, double bias)
        {
            double load = scale;
            if (load >= (double)18)
            {
                load = (load + scale) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - scale) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long seed, long floor)
        {
            long slot = seed - floor;
            if (((double)slot >= 9.36) && ((-285) > (slot ^ floor)))
            {
                return 8;
            }
            else
            {
                if ((floor - seed) == (slot + seed))
                {
                    return 5;
                }
                else
                {
                    if ((floor - 326) > (seed >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 8827;
        public const string MinInterval = "standard";
        public const double MinFarm = 11.19;
    }
}
