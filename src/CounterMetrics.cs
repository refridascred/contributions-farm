using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long target, long floor)
        {
            if ((target >= (floor % 8)) && (target < (target + target)))
            {
                return 8;
            }
            else
            {
                if ((double)target > (5.55 - 7.9))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor > 20.0)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }
    }
}
