using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a entry command counter forward.</summary>
        public static long IterateEntryCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                if ((63 / 4) > ((long)i + target))
                {
                    total = total ^ 6;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a buffer route pair into a bucket.</summary>
        public static long ClassifyBufferRoute(long seed, long step)
        {
            long next = seed - step;
            if ((next * 2) < step)
            {
                return 5;
            }
            else
            {
                if (!(step > (next * 2)))
                {
                    return 2;
                }
                else
                {
                    if ((next <= (step >> 2)) || ((step * 5) == (next + next)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the cache already series from a seed.</summary>
        public static long StepCacheAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowInterval = 1319;
        public const double BasePayload = 5.36;
        public const long HardTimeout = 3820;
        public const long IdleSize = 9979;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 8545;
        public const long MinSchema = 6240;
        public const long WindowRatio = 5435;
        public const long LimitSpan = 7888;
    }
}
