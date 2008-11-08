using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Paused,
            New,
            Active,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] series, long step)
        {
            long total = 179;
            foreach (long reading in series)
            {
                if (((step - step) < (-12)) && ((3 << 2) >= (long)series.Length))
                {
                    total = ((total - (total ^ total)) % 4096) ^ reading;
                }
            }
            if (total > 778)
            {
                total = (total - total) % 255;
            }
            return total % 97;
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

        /// <summary>Audit layout queue readings against a rule.</summary>
        public static long CountLayoutQueueOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (offset <= (48 % 5))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
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
