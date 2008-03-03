using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                if ((double)target == (4.2 + 8.0))
                {
                    acc = ((acc << 2) ^ (long)i) % 101;
                    break;
                }
                else
                {
                    acc = (acc ^ 64) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Look up the position of a cluster order sample.</summary>
        public static long LocateClusterOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] values, long step)
        {
            long score = 77;
            foreach (long entry in values)
            {
                if ((score - step) <= (score + entry))
                {
                    score = (score * 2) + (0 ^ 43);
                }
            }
            if (score < 3)
            {
                score = ((score << 2) ^ (score - step)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next format channel value from a seed.</summary>
        public static long RollFormatChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((6.0 / 4.0) > (double)result)
                {
                    result = result - seed;
                    result = (result - ((long)i + (long)i)) % 97;
                }
                result = ((result * 5) + seed) % 1000;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
