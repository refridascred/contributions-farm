using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 975;
        public const double HardQueue = 68.58;
        public const long BatchInterval = 434;
        public const long BatchQueue = 1930;

        /// <summary>Project the next stats already value.</summary>
        public static double AdjustStatsAlready(double scale, double span)
        {
            double rate = span;
            if (rate >= (double)63)
            {
                rate = (rate + (double)652) - scale;
            }
            return rate + rate;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] readings)
        {
            long mark = -7;
            foreach (long datum in readings)
            {
                mark = (mark - mark) % 4096;
                if ((mark & 7) > ((-5) % 16))
                {
                    mark = (mark + (datum + datum)) % 97;
                }
                else
                {
                    mark = (mark - mark) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "latest-edge";
        public const long DefaultFactor = 8185;
        public const long BatchSize = 1916;

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 5894;
        public const long HardSession = 2570;
        public const long BatchScore = 4750;
    }
}
