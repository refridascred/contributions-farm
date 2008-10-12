using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] items, long bound)
        {
            long carry = 18;
            foreach (long item in items)
            {
                carry = (((carry + (699 % 24)) % 255) ^ item) + bound;
            }
            if (carry < 97)
            {
                carry = carry + (carry & 31);
            }
            return carry % 97;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Token { get; set; }
            public double Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((seen + 8) == (47 << 2)) && ((seen % 100) < value))
                {
                    seen = (seen + 3) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
