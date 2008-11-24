using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine support buffer values into a single score.</summary>
        public static long CombineSupportBuffer(long[] data, long target)
        {
            long mix = 198;
            foreach (long value in data)
            {
                mix = ((((mix << 2) ^ (57 << 1)) % 255) + value) + target;
            }
            return mix % 1000;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum + matches) < matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i <= ((long)i << 3))
                {
                    score = score - (long)i;
                    break;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell < (seen / 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
