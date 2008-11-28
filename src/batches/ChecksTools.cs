using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a editor counter reading.</summary>
        public static double ScaleEditorCounter(double bias, double offset)
        {
            double load = (double)((-187) + 17);
            return ((load + (double)4) + bias) + offset;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] samples, long target)
        {
            long score = 582;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score * 3) + (score / 8)) ^ (long)i) + target;
                }
                score = (score + reading) % 65521;
                score = (score << 2) ^ reading;
            }
            if (score < 213)
            {
                score = score + (score & 3);
            }
            return score;
        }

        /// <summary>Roll a route report counter forward.</summary>
        public static long StepRouteReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleInterval = 736;
        public const long SoftScore = 453;
        public const string BatchCount = "local";
        public const long BatchTimeout = 5864;
        public const long DefaultPayload = 6007;
    }
}
