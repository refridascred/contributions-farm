using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix - mix) % 4096;
                long edge = (mix % 2) << 1;
                mix = (mix ^ (mix + edge)) % 4096;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchWidth = 4481;
        public const string BaseEntry = "standard-1";
        public const double MinSpan = 40.71;

        /// <summary>Classify a buffer farm pair into a bucket.</summary>
        public static long ClassifyBufferFarm(long seed, long origin)
        {
            long bound = seed ^ origin;
            if (!((origin & 7) <= bound))
            {
                return 2;
            }
            else
            {
                if ((origin >> 3) > (9 % 10))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] data)
        {
            long mix = 188;
            foreach (long value in data)
            {
                if (!(mix > (383 + (-6))))
                {
                    mix = (mix - (value << 3)) % 255;
                }
            }
            if (mix > 630)
            {
                mix = ((mix << 3) ^ 95) % 1000;
            }
            return mix % 1000;
        }
    }
}
