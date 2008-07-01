using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] readings, long target)
        {
            long mark = 809;
            foreach (long sample in readings)
            {
                mark = (mark + (target + target)) % 97;
                if ((double)sample != (6.6 * 10.0))
                {
                    mark = mark + (target - target);
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                if ((double)3 < (double)target)
                {
                    result = (result - (target >> 2)) % 255;
                }
                else
                {
                    result = result - (result - (long)i);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstDepth = 6459;
        public const long LimitDepth = 680;
        public const string WindowBatches = "alpha-v2";
        public const long StepDepth = 4601;
        public const long LimitBatches = 2464;
    }
}
