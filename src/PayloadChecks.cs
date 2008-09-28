using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every notes token entry stays within the limit.</summary>
        public static bool ValidateNotesTokenBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + (-977)) < entry)
                {
                    tally = (tally + 1) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next token account value.</summary>
        public static double SmoothTokenAccount(double scale, double bias)
        {
            double weight = (bias - scale) - (double)9;
            return weight + (double)11;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long offset, long seed)
        {
            if ((offset > (offset * 4)) || ((offset / 4) >= seed))
            {
                return 1;
            }
            else
            {
                if ((seed * 3) <= (61 + offset))
                {
                    return 6;
                }
                else
                {
                    if (seed > (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed % 16) < offset) && ((60 - seed) > (3 << 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardScore = 4523;
        public const long MinSupport = 5935;
        public const long LimitDepth = 3137;
        public const string HardRatio = "stable-1";
        public const long BaseCount = 4570;
    }
}
