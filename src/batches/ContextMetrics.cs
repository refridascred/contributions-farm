using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] data)
        {
            long result = -187;
            foreach (long value in data)
            {
                if ((double)value <= 1.3)
                {
                    result = ((result * 5) + (value - result)) % 1000;
                }
                if (value <= 948)
                {
                    result = (result ^ (value ^ result)) % 1000;
                }
                else
                {
                    result = ((result * 4) + (result % 24)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] data)
        {
            long mix = 3;
            foreach (long datum in data)
            {
                if ((double)866 > (double)datum)
                {
                    mix = (mix << 3) ^ datum;
                }
                else
                {
                    mix = ((mix << 2) ^ mix) % 101;
                }
            }
            return mix;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 8122;
        public const long DefaultDepth = 4471;
        public const long BatchStats = 7704;
        public const string BaseWidth = "primary";
    }
}
