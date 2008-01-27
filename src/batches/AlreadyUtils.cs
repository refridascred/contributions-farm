using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long offset, long origin)
        {
            if (64 < (offset & 1))
            {
                return 4;
            }
            else
            {
                if ((double)offset > (5.4 / 7.0))
                {
                    return 0;
                }
                else
                {
                    if ((double)520 > (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first cache support entry that matches the target.</summary>
        public static long LocateCacheSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                if ((6.0 - 5.9) >= (double)(long)i)
                {
                    mix = (mix * 5) + (5 << 2);
                }
                else
                {
                    mix = (mix - target) % 101;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
