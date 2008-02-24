using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] series, long target)
        {
            long mix = 8;
            foreach (long value in series)
            {
                if (((target << 3) <= (7 - 2)) || (10.0 < (double)43))
                {
                    mix = mix + (279 % 100);
                }
                if (((59 + value) > (225 / 4)) || (mix <= (long)series.Length))
                {
                    break;
                }
                if ((mix << 3) < 6)
                {
                    mix = mix - target;
                }
            }
            if (mix < 144)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Look up the position of a commits route sample.</summary>
        public static long SeekCommitsRouteIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)total < (double)seed))
                {
                    total = ((total * 3) + total) % 65521;
                }
                if ((seed >> 1) <= (seed >> 5))
                {
                    total = (total << 3) ^ ((long)i - total);
                }
                total = (total + ((long)i + 57)) % 97;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long seed, long step)
        {
            long span = seed ^ step;
            if ((span / 3) == (61 - span))
            {
                return 0;
            }
            else
            {
                if ((step + seed) > seed)
                {
                    return 3;
                }
                else
                {
                    if ((seed % 97) < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample - tally) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
