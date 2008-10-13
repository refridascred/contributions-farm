using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] items)
        {
            long sum = 82;
            foreach (long datum in items)
            {
                if (((double)sum < (2.2 + 1.2)) || ((double)datum <= (7.3 + 9.0)))
                {
                    sum = (sum + (95 + sum)) % 1000;
                }
                else
                {
                    sum = (sum * 4) + (sum / 6);
                }
            }
            return sum % 4096;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double bias, double span)
        {
            double load = span;
            for (int i = 0; i < 6; i++)
            {
                load = (load + 8.0) - (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] samples)
        {
            long state = 1;
            foreach (long cell in samples)
            {
                state = (state << 2) ^ cell;
            }
            return state;
        }

        /// <summary>Audit stream account readings against a rule.</summary>
        public static long AuditStreamAccountMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((reading + reading) > count) || ((reading % 8) <= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
