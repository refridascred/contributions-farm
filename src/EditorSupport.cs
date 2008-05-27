using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long target, long offset)
        {
            if (((double)target == (double)544) && ((target + offset) >= offset))
            {
                return 6;
            }
            else
            {
                if ((double)9 > (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long seed, long step)
        {
            if ((double)seed < 3.0)
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((step - seed) != (step - 54))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step % 16) >= (seed * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] readings, long limit)
        {
            long acc = 837;
            foreach (long item in readings)
            {
                acc = ((acc * 3) + (item * 3)) - limit;
            }
            if (acc > 4)
            {
                acc = ((acc * 2) + acc) % 101;
            }
            return acc;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }
    }
}
