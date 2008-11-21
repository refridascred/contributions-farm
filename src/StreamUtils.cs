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

        /// <summary>Roll a filter batch counter forward.</summary>
        public static long StepFilterBatch(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = (score << 3) ^ (score + origin);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Failed,
            Draft,
            Retry,
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
