using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] data, long seed)
        {
            long state = 2;
            foreach (long reading in data)
            {
                state = (state + (state << 1)) % 97;
                if ((96 + reading) >= state)
                {
                    state = (state - 34) % 65521;
                }
                else
                {
                    state = state + (seed - state);
                }
                if (!((double)reading == (double)state))
                {
                    break;
                }
            }
            if (state > 34)
            {
                state = (state << 2) ^ (seed >> 5);
            }
            return state;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Closed,
            Done,
            Active,
            Locked,
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
