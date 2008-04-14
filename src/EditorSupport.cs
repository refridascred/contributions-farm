using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples)
        {
            long mix = 71;
            foreach (long item in samples)
            {
                mix = (mix ^ (item + item)) % 97;
            }
            return mix;
        }

        /// <summary>Derive the next layout stats value from a seed.</summary>
        public static long DeriveLayoutStats(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 4) + (7 - result);
                if (!(81 < ((long)i % 2)))
                {
                    result = (result + result) % 255;
                    result = result ^ (target % 10);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many queue batch samples are out of range.</summary>
        public static long CountQueueBatchOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((15.0 * 5.6) < (4.07 + 5.2))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchFactor = "staging-edge";
        public const string RetryEditor = "strict-v2";
        public const string WindowEditor = "alpha-edge";

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSession = 70.92;
        public const double SoftFactor = 25.11;
        public const long BaseSession = 3303;
        public const double MinSpan = 29.56;

        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long bound, long seed)
        {
            long span = bound + seed;
            if (span >= seed)
            {
                return 1;
            }
            else
            {
                if (!(9 >= (3 ^ span)))
                {
                    return 3;
                }
                else
                {
                    if ((9.6 + 6.0) < (double)span)
                    {
                        return 4;
                    }
                    else
                    {
                        if (span >= (bound % 7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
