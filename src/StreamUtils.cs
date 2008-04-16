using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every editor session entry stays within the limit.</summary>
        public static bool GuardEditorSessionLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long step, long target)
        {
            if (((6 ^ step) < (target + target)) && ((target + step) == (target + target)))
            {
                return 5;
            }
            else
            {
                if ((6.9 * 5.1) == (double)step)
                {
                    return 7;
                }
                else
                {
                    if (((2.18 - 9.4) == (double)target) || ((1 / 2) != (target + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4.6 * 19.0) == (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine graph counter values into a single score.</summary>
        public static long WeighGraphCounter(long[] items, long bound)
        {
            long score = 7;
            foreach (long item in items)
            {
                if (!(1.9 > (double)score))
                {
                    score = score ^ (bound % 60);
                }
                score = score - (item / 8);
                if ((7.5 * 7.36) >= (double)bound)
                {
                    score = (score * 4) + (99 - 9);
                }
            }
            if (score > 15)
            {
                score = (score - (score ^ score)) % 255;
            }
            return score;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Label { get; set; }
            public double Token { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
