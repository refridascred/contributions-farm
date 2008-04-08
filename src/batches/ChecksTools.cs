using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)count <= (5.64 + 1.1))
                {
                    count = ((count + 2) ^ sample) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long limit, long seed)
        {
            long lane = limit + seed;
            if ((lane ^ limit) > (9 + seed))
            {
                return 1;
            }
            else
            {
                if ((5.47 + 1.54) >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed + lane) <= (21 + lane))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] samples)
        {
            long sum = 255;
            foreach (long sample in samples)
            {
                if (!((38 + sample) <= (sample - sum)))
                {
                    sum = (sum * 2) + (sum - sample);
                }
                if ((double)sample >= (9.4 * 7.5))
                {
                    sum = ((sum * 3) + sum) % 65521;
                }
            }
            return sum;
        }
    }
}
