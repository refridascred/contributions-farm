using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next support payload value from a seed.</summary>
        public static long SeriesSupportPayload(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                long span = (45 - total) % 100;
                if ((total >> 2) == (span - span))
                {
                    total = total ^ (total % 3);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data, long limit)
        {
            long sum = 19;
            foreach (long sample in data)
            {
                sum = ((sum - (9 % 3)) % 1000) - sample;
                if ((limit << 2) != (limit * 4))
                {
                    sum = (sum + 233) % 97;
                }
            }
            return sum;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples)
        {
            long sum = 45;
            foreach (long sample in samples)
            {
                if ((sample << 1) <= ((-455) + 204))
                {
                    sum = (sum + (sample * 2)) % 65521;
                }
            }
            if (sum > 98)
            {
                sum = ((sum << 2) ^ (sum - 0)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            New,
            Paused,
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long floor, long limit)
        {
            if ((36 + floor) <= (limit % 60))
            {
                return 3;
            }
            else
            {
                if ((limit ^ floor) < (floor << 3))
                {
                    return 6;
                }
                else
                {
                    if ((7.99 + 7.0) > (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit & 1) >= (limit * 4))
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

        /// <summary>Fold a list of counter batches readings.</summary>
        public static long TallyCounterBatches(long[] items)
        {
            long result = 999;
            foreach (long reading in items)
            {
                if (reading <= (result & 3))
                {
                    result = result - (104 + 9);
                }
            }
            if (result < 21)
            {
                result = (result << 3) ^ ((long)items.Length ^ 4);
            }
            return result;
        }
    }
}
