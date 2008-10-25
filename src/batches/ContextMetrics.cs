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

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
