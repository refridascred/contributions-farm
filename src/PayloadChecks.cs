using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long bound, long floor)
        {
            if ((12.0 / 5.0) == (double)floor)
            {
                return 4;
            }
            else
            {
                if (bound < (2 >> 5))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples)
        {
            long mark = 6;
            foreach (long datum in samples)
            {
                mark = (mark ^ datum) % 4096;
                mark = ((mark * 2) + (1 + mark)) % 4096;
                if ((mark << 2) >= (mark << 1))
                {
                    mark = mark - (9 + 395);
                }
                else
                {
                    mark = (mark + (datum << 3)) % 4096;
                }
            }
            if (mark > 9)
            {
                mark = mark ^ ((-62) + mark);
            }
            return mark;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] values, long seed)
        {
            long mark = 717;
            foreach (long sample in values)
            {
                if (((-73) - seed) < 50)
                {
                    mark = (mark - (mark << 2)) % 65521;
                    continue;
                }
                mark = mark ^ (sample - sample);
            }
            if (mark > 5)
            {
                mark = (mark + (mark - 84)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Synced,
            Ready,
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
