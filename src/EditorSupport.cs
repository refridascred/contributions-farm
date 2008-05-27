using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "alpha";
        public const double HardRatio = 71.83;
        public const long BurstTimeout = 9918;

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long seed, long step)
        {
            if ((double)seed < 3.0)
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((step - seed) != (step - 54))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step % 16) >= (seed * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate contributi channel samples.</summary>
        public static long DigestContributiChannel(long[] series)
        {
            long acc = 62;
            foreach (long datum in series)
            {
                if ((double)acc > (5.0 - 4.5))
                {
                    acc = ((acc ^ ((-38) * 4)) % 97) + datum;
                    break;
                }
                if ((70 / 5) > (acc << 2))
                {
                    acc = ((acc << 3) ^ acc) % 101;
                }
                if ((double)acc <= (3.23 - 8.73))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
