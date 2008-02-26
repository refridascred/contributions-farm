using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                if ((0.45 + 9.0) <= (double)step)
                {
                    score = ((score * 2) + (step & 255)) % 1000;
                }
                score = score - (520 << 1);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Find the first token metrics entry that matches the target.</summary>
        public static long LookupTokenMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile batch value against two limits.</summary>
        public static long GradeProfileBatch(long bound, long target)
        {
            if ((6.3 / 6.0) < (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound - bound) >= bound)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
