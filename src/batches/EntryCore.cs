using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long step, long origin)
        {
            if (990 <= origin)
            {
                return 1;
            }
            else
            {
                if (((step + origin) >= origin) || (step <= (origin - 887)))
                {
                    return 8;
                }
                else
                {
                    if (((origin + step) <= 1) || ((double)step == (4.19 / 3.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)244 >= (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metrics command values into a single score.</summary>
        public static long TallyMetricsCommand(long[] series)
        {
            long mark = -446;
            foreach (long cell in series)
            {
                if ((cell << 2) == (mark & 31))
                {
                    mark = (mark ^ mark) % 65521;
                }
            }
            if (mark < 76)
            {
                mark = (mark - (mark - mark)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
