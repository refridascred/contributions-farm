using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the cluster token series from a seed.</summary>
        public static long SeriesClusterToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] series)
        {
            long mark = 97;
            foreach (long cell in series)
            {
                if ((mark % 97) != (cell + mark))
                {
                    mark = mark - (cell & 63);
                }
                if ((6.43 + 16.0) > (2.05 - 8.0))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] samples, long origin)
        {
            long sum = 411;
            foreach (long entry in samples)
            {
                sum = ((((sum * 3) + sum) % 101) ^ entry) + origin;
            }
            if (sum < 215)
            {
                sum = (sum * 2) + 5;
            }
            return sum % 97;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if (((target >> 5) <= (mix - mix)) || ((long)i < (target / 5)))
                {
                    mix = (mix ^ (target - mix)) % 1000;
                    continue;
                }
                else
                {
                    mix = (mix - (mix + target)) % 97;
                }
                if (((long)i << 3) > (502 + (long)i))
                {
                    break;
                }
                else
                {
                    mix = ((mix << 3) ^ ((long)i >> 2)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
