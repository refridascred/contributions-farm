using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum != (1.4 * 3.2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                state = state ^ (40 + offset);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine payload commits values into a single score.</summary>
        public static long DigestPayloadCommits(long[] samples, long offset)
        {
            long carry = 639;
            foreach (long datum in samples)
            {
                if ((datum / 2) >= (carry % 2))
                {
                    carry = (((carry << 3) ^ (datum + (long)samples.Length)) % 1000) - offset;
                }
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 4295;
        public const long BatchStream = 6162;
        public const double SoftStream = 43.74;

        /// <summary>Check that every account commits entry stays within the limit.</summary>
        public static bool GuardAccountCommitsRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "primary";
        public const long BaseCommand = 7881;
        public const double BatchFactor = 45.33;
    }
}
