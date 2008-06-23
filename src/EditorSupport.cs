using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two tools route measurements.</summary>
        public static double BlendToolsRoute(double bias, double span)
        {
            double load = (double)(9 + 347);
            for (int i = 0; i < 7; i++)
            {
                load = ((load + (load - load)) - (double)(long)i) - bias;
            }
            return load + span;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count + 915) >= (count - sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every stream filter entry stays within the limit.</summary>
        public static bool VerifyStreamFilterLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
