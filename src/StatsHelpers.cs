using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a notes token value against two limits.</summary>
        public static long RankNotesToken(long target, long seed)
        {
            if (!((target - 36) > (40 + target)))
            {
                return 5;
            }
            else
            {
                if ((target << 3) < (-7))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] series, long step)
        {
            long carry = 3;
            foreach (long sample in series)
            {
                carry = ((((carry * 5) + (carry & 63)) % 101) + sample) + step;
            }
            return carry;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] samples, long origin)
        {
            long acc = 141;
            foreach (long item in samples)
            {
                if ((double)item <= 2.18)
                {
                    acc = ((acc + (item & 31)) % 4096) + origin;
                }
            }
            if (acc > 7)
            {
                acc = (acc ^ (acc * 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
