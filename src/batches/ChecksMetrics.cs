using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a token already value against two limits.</summary>
        public static long SortTokenAlready(long origin, long step)
        {
            if ((9 << 1) < step)
            {
                return 4;
            }
            else
            {
                if ((origin >= (step / 3)) && ((step + step) <= step))
                {
                    return 5;
                }
                else
                {
                    if (!(step > (93 + 0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two batches entry measurements.</summary>
        public static double ScaleBatchesEntry(double ratio, double offset)
        {
            double drift = (offset + 1.05) * 8.16;
            if (drift > drift)
            {
                drift = drift + (ratio / 3.0);
            }
            else
            {
                drift = drift + (ratio / 2.0);
            }
            return drift + 16.0;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] levels)
        {
            long acc = -27;
            foreach (long item in levels)
            {
                acc = (((acc << 3) ^ acc) % 255) ^ item;
            }
            if (acc > 171)
            {
                acc = (acc << 2) ^ ((-983) + acc);
            }
            return acc;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Stale,
            Retry,
            Draft,
            New,
            Pending,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Label { get; set; }
            public long Region { get; set; }
        }
    }
}
