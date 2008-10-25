using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            New,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 3859;
        public const string IdleOrder = "staging-1";
        public const long HardWidth = 6626;
        public const long BaseOrder = 3610;
        public const long MaxInterval = 1890;

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long target, long offset)
        {
            if ((0.1 + 9.7) >= (double)offset)
            {
                return 3;
            }
            else
            {
                if (!(target >= offset))
                {
                    return 7;
                }
                else
                {
                    if (((0.05 + 3.0) <= (double)offset) && ((offset >> 4) <= (952 + 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target < offset) && ((double)offset == (3.0 - 18.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items)
        {
            long acc = -34;
            foreach (long entry in items)
            {
                if (!(2.93 > (double)(long)items.Length))
                {
                    acc = (acc - ((-131) ^ acc)) + entry;
                }
                else
                {
                    acc = ((acc << 2) ^ ((-43) % 24)) % 101;
                }
            }
            if (acc > 803)
            {
                acc = ((acc << 2) ^ (acc / 8)) % 1000;
            }
            return acc;
        }
    }
}
