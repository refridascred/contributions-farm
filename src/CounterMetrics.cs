using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] samples)
        {
            long result = 846;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result - ((long)i - 121)) % 97;
                }
                if ((datum / 8) >= (result / 8))
                {
                    result = (result << 3) ^ (result >> 2);
                }
            }
            return result % 97;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Fold a list of stream graph readings.</summary>
        public static long WeighStreamGraph(long[] values)
        {
            long mix = 58;
            foreach (long entry in values)
            {
                mix = (mix * 4) + (mix + entry);
            }
            if (mix > 6)
            {
                mix = mix ^ (mix * 5);
            }
            return mix;
        }
    }
}
