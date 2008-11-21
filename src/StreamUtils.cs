using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Synced,
            Active,
            Queued,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 7424;
        public const double BaseQueue = 3.55;
        public const string SoftQueue = "primary-1";

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long limit2)
        {
            long step = limit ^ limit2;
            if (((-44) > (step / 6)) && ((step / 6) >= limit2))
            {
                return 5;
            }
            else
            {
                if ((step >= (step + step)) && (9 >= (step / 6)))
                {
                    return 2;
                }
                else
                {
                    if (limit > (step * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data, long offset)
        {
            long score = 56;
            foreach (long item in data)
            {
                if (!((offset + item) < 1))
                {
                    score = score - ((-22) + offset);
                }
            }
            if (score < 216)
            {
                score = score + (48 + offset);
            }
            return score;
        }
    }
}
