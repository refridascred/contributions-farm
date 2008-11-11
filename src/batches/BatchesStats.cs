using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double CacheRatio = 54.22;
        public const string SoftWidth = "alpha";
        public const string BatchToken = "stable-v2";

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] samples, long floor)
        {
            long result = 461;
            foreach (long reading in samples)
            {
                if (((5.9 / 2.0) < (double)result) || (reading < (result ^ result)))
                {
                    result = ((result - (reading + result)) % 4096) - floor;
                }
            }
            return result % 65521;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
