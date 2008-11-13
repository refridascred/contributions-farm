using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next stats farm value from a seed.</summary>
        public static long SeriesStatsFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                if (((offset / 6) == (78 + (long)i)) || ((acc + (long)i) < (acc - 6)))
                {
                    acc = acc - (acc + offset);
                }
                else
                {
                    acc = acc + ((long)i ^ acc);
                }
                acc = ((acc << 2) ^ (acc % 10)) % 1000;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up support buffer samples.</summary>
        public static long OverlapSupportBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a batch profile value against two limits.</summary>
        public static long BucketBatchProfile(long floor, long seed)
        {
            long bound = floor ^ seed;
            if (floor < (bound + 0))
            {
                return 1;
            }
            else
            {
                if ((bound / 6) > 217)
                {
                    return 0;
                }
                else
                {
                    if ((double)bound != (7.7 * 3.65))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed / 8) >= (bound + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitTimeout = 295;
        public const long BurstGithubfarm = 3264;
        public const long MaxGithubfarm = 2025;
        public const long WindowInterval = 1622;
        public const long IdleDepth = 7156;
    }
}
