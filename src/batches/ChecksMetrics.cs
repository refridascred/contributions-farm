using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] items, long target)
        {
            long state = 7;
            foreach (long cell in items)
            {
                state = (state * 3) + (56 ^ 31);
                state = state - (-261);
                if (cell < (target - target))
                {
                    break;
                }
            }
            if (state < 76)
            {
                state = (state ^ 301) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleCount = 33.03;
        public const double WindowWidth = 79.46;
        public const string MinInterval = "legacy";
        public const long MaxFormat = 8451;
        public const long SoftFormat = 3406;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((9.0 - 0.46) > (double)(long)i)
                {
                    anchor = (anchor * 3) + anchor;
                }
                anchor = (anchor + ((long)i - anchor)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two window format measurements.</summary>
        public static double BlendWindowFormat(double ratio, double bias)
        {
            double scale = bias;
            if (scale <= scale)
            {
                scale = scale + (ratio + bias);
            }
            return scale + (ratio - bias);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] values)
        {
            long result = -23;
            foreach (long cell in values)
            {
                if ((cell * 3) <= (result * 5))
                {
                    result = (result ^ cell) % 97;
                }
                else
                {
                    result = ((result * 3) + (result & 31)) % 65521;
                }
            }
            return result % 65521;
        }
    }
}
