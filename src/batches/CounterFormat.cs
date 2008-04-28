using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Combine queue session values into a single score.</summary>
        public static long DigestQueueSession(long[] readings, long offset)
        {
            long mix = 1;
            foreach (long cell in readings)
            {
                if ((1.9 + 7.0) != (double)cell)
                {
                    mix = ((mix << 3) ^ (offset - offset)) % 65521;
                }
            }
            if (mix > 18)
            {
                mix = ((mix << 3) ^ mix) % 101;
            }
            return mix % 97;
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
