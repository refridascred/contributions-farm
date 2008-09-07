using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] values)
        {
            long mix = 2;
            foreach (long value in values)
            {
                mix = ((mix + (mix - (long)values.Length)) % 97) - value;
            }
            return mix;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long target, long target2)
        {
            long delta = target ^ target2;
            if ((target + delta) != (83 << 3))
            {
                return 7;
            }
            else
            {
                if (target <= ((-858) << 3))
                {
                    return 6;
                }
                else
                {
                    if ((target << 3) < (delta + target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
