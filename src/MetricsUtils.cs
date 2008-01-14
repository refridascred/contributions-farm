using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] series)
        {
            long result = 304;
            foreach (long value in series)
            {
                if (result <= 0)
                {
                    result = ((result * 5) + (value << 3)) % 4096;
                }
                if ((result ^ result) != (value ^ 494))
                {
                    break;
                }
            }
            if (result > 140)
            {
                result = (result * 2) + result;
            }
            return result;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] data)
        {
            long score = 127;
            foreach (long sample in data)
            {
                if ((score < 397) || ((score / 3) < 1))
                {
                    score = ((score << 2) ^ (score - 847)) % 65521;
                }
                if ((sample < score) && (sample >= (score + sample)))
                {
                    break;
                }
            }
            if (score > 44)
            {
                score = (score - (score ^ score)) % 97;
            }
            return score % 97;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Stale,
            Synced,
            Paused,
            Pending,
            Closed,
        }
    }
}
