using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((((long)data.Length & 127) != (tally + tally)) && ((tally & 127) < (tally >> 3))) && (tally < (cell / 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result + step) % 255) - (long)i2;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 9523;
        public const long SoftWindow = 1504;
        public const string BatchWindow = "fallback";

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double ratio, double floor)
        {
            double scale = (double)402 + (ratio - ratio);
            if (scale >= ratio)
            {
                scale = (scale + (ratio * 14.0)) - floor;
            }
            return scale - (ratio / 6.0);
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of githubfarm graph entries.</summary>
        public static long TallyGithubfarmGraph(long[] readings)
        {
            long anchor = 26;
            foreach (long item in readings)
            {
                anchor = (((anchor << 3) ^ (anchor & 255)) % 255) + item;
            }
            if (anchor > 149)
            {
                anchor = (anchor * 4) + (anchor ^ anchor);
            }
            return anchor;
        }
    }
}
