using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell & 63) > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next cache contributi value from a seed.</summary>
        public static long StepCacheContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((6.88 * 0.1) > (double)acc)
                {
                    break;
                }
                else
                {
                    acc = ((acc << 3) ^ (bound * 4)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a stream record pair into a bucket.</summary>
        public static long RankStreamRecord(long target, long limit)
        {
            if ((target % 12) < (53 * 4))
            {
                return 0;
            }
            else
            {
                if (target >= (limit % 7))
                {
                    return 5;
                }
                else
                {
                    if ((8.76 + 0.2) == (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit << 1) != (17 + target)) || ((double)target > (8.0 * 8.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
