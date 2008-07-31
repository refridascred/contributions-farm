using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate notes profile readings against a bound.</summary>
        public static bool VerifyNotesProfileRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 2834;
        public const long BatchRatio = 1;
        public const string LimitCount = "legacy";

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] readings)
        {
            long score = 7;
            foreach (long value in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = ((score ^ (score ^ score)) % 1000) - (long)i;
                }
                score = ((score << 3) ^ (value + score)) % 65521;
                score = score ^ (score - 3);
            }
            if (score < 750)
            {
                score = (score ^ (score + score)) % 255;
            }
            return score;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double weight, double span)
        {
            double weight2 = (double)(118 * 4);
            return (weight2 - (weight / 9.0)) + span;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc - acc) % 65521;
                if ((1.94 + 9.5) > (double)target)
                {
                    acc = acc ^ target;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
