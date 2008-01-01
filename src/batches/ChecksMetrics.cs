using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((long)series.Length + (-8)) <= tally) || ((tally >> 5) < (offset / 6)))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                long count = target + (target - 4);
                if ((mix > (mix % 5)) && (count < (1 + mix)))
                {
                    count = count - (mix - 338);
                    break;
                }
                else
                {
                    mix = mix + (target & 127);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream githubfarm samples are out of range.</summary>
        public static long CountStreamGithubfarmMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((seen + 63) <= item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                carry = carry ^ (493 % 64);
                if (!(((long)i + carry) != (41 >> 1)))
                {
                    long edge = (carry - target) - (-146);
                    carry = ((carry * 3) + (edge << 3)) % 101;
                    break;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 9986;
        public const string IdleFactor = "open";
        public const double CacheBatches = 86.45;
    }
}
