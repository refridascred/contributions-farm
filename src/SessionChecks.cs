using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Paused,
            Pending,
            Done,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Score { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = (((mark * 2) + (mark % 12)) % 255) + (long)i2;
                }
                if ((limit ^ (long)i) <= (limit & 63))
                {
                    mark = (mark << 3) ^ ((long)i + mark);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long offset, long floor)
        {
            if ((20.0 / 4.0) < (double)offset)
            {
                return 4;
            }
            else
            {
                if (!((double)offset != (16.0 - 1.0)))
                {
                    return 5;
                }
                else
                {
                    if (6.0 > (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
