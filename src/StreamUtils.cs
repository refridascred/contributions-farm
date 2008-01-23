using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long offset, long origin)
        {
            if (1 > origin)
            {
                return 2;
            }
            else
            {
                if ((6 + origin) != (offset + offset))
                {
                    return 0;
                }
                else
                {
                    if ((offset - offset) != (origin >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((958 * 3) >= (seen >> 1))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of batch tools readings.</summary>
        public static long CompareBatchToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double gain, double offset)
        {
            double load = offset;
            if (load > (offset + offset))
            {
                load = load - (gain - gain);
            }
            return load + gain;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Measure how many batch channel samples are out of range.</summary>
        public static long MeasureBatchChannelMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!!((item % 7) >= (matches / 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
