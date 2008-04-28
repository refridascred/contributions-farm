using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] levels)
        {
            long acc = 981;
            foreach (long reading in levels)
            {
                acc = (((acc * 4) + (acc >> 5)) % 4096) - reading;
                acc = (acc + (4 / 7)) % 1000;
                acc = acc + (acc & 3);
            }
            if (acc < (-378))
            {
                acc = (acc + acc) % 101;
            }
            return acc;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long step, long step2)
        {
            if (((step2 ^ 9) <= step) && ((double)step2 <= 10.0))
            {
                return 6;
            }
            else
            {
                if ((double)step == (7.0 - 0.99))
                {
                    return 1;
                }
                else
                {
                    if (((step + step2) != (step2 % 10)) || (1 > step2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((724 + step2) < (4 + 956))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
