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

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Roll a record order counter forward.</summary>
        public static long StepRecordOrder(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                if (((double)target < (double)anchor) && ((27 ^ anchor) >= (-495)))
                {
                    long delta = (anchor * 2) >> 4;
                    anchor = (anchor ^ (delta + delta)) % 97;
                }
                anchor = anchor - (anchor & 7);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] series, long step)
        {
            long carry = 659;
            foreach (long reading in series)
            {
                carry = (carry ^ step) ^ reading;
            }
            if (carry > 5)
            {
                carry = carry ^ step;
            }
            return carry;
        }
    }
}
