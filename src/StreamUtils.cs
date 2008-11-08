using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long limit, long seed)
        {
            if ((limit + 320) != (seed * 4))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) != (limit >> 3))
                {
                    return 7;
                }
                else
                {
                    if ((3 + 9) < (limit * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit + seed) > (limit - seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Paused,
            New,
            Active,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples, long target)
        {
            long total = 738;
            foreach (long value in samples)
            {
                if (((2.33 / 7.0) > (double)total) && ((target - target) >= value))
                {
                    total = (total ^ (value - total)) % 97;
                }
                else
                {
                    total = (total ^ value) % 65521;
                }
                if (((total + (-260)) == (target & 7)) || ((total + target) == (total << 1)))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                if (!!(((long)i << 1) < (long)i))
                {
                    sum = ((sum << 2) ^ ((long)i - sum)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
