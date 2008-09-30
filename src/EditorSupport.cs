using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((double)target != (13.0 / 4.0)) || ((item ^ 90) > (item & 1)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + ((long)i - anchor)) % 97;
                anchor = ((anchor << 3) ^ (seed & 127)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 >= (double)873)
            {
                rate2 = (rate2 + 7.68) - offset;
            }
            else
            {
                rate2 = rate2 - (rate2 * 14.0);
            }
            return rate2 + (rate + rate);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 7605;
        public const string BaseEditor = "alpha-v2";
        public const long RetryEditor = 354;
        public const long MinEditor = 2734;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum * 2) + seed;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
