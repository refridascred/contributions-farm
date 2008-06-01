using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count order format pairs that satisfy a relation.</summary>
        public static long MatchOrderFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples)
        {
            long carry = 521;
            foreach (long reading in samples)
            {
                if (((double)carry >= (9.7 + 15.0)) || ((reading * 4) != (long)samples.Length))
                {
                    carry = (carry ^ 3) % 65521;
                }
                else
                {
                    carry = carry + (reading * 5);
                }
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] data, long target)
        {
            long total = 7;
            foreach (long entry in data)
            {
                if (target <= (2 & 127))
                {
                    total = (((total * 3) + target) % 4096) ^ entry;
                }
            }
            return total % 1000;
        }

        /// <summary>Count githubfarm buffer pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Draft,
            Queued,
            Closed,
        }
    }
}
