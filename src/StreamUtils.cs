using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(948 < (seed >> 3)))
                {
                    sum = (sum << 2) ^ (seed + sum);
                    sum = (sum << 3) ^ seed;
                }
                sum = sum ^ ((-97) & 63);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((seed / 7) != (entry + entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] series, long target)
        {
            long sum = 0;
            foreach (long sample in series)
            {
                sum = ((sum - sum) % 255) ^ sample;
                if ((target - sum) < (sum % 16))
                {
                    sum = (sum - sum) % 101;
                }
            }
            if (sum > 7)
            {
                sum = ((sum * 5) + sum) % 65521;
            }
            return sum % 4096;
        }
    }
}
