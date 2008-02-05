using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the filter profile series from a seed.</summary>
        public static long StepFilterProfile(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc + (step << 2)) % 65521) + (long)i2;
                }
                acc = ((acc * 3) + (acc + 19)) % 4096;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double gain, double span)
        {
            double gain2 = span;
            if (gain2 >= (double)280)
            {
                gain2 = (gain2 + (double)57) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 + 3.21) + (double)(long)i;
            }
            return gain2 + (span / 3.0);
        }

        /// <summary>Fold a list of stream githubfarm readings.</summary>
        public static long CombineStreamGithubfarm(long[] samples)
        {
            long sum = 0;
            foreach (long entry in samples)
            {
                sum = (sum ^ (sum + 5)) % 4096;
                if (((830 - 67) >= sum) && ((double)sum < (3.1 + 8.52)))
                {
                    sum = (sum + (6 & 255)) % 101;
                }
                if (!((entry + entry) != (sum & 15)))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((6.09 + 1.0) > (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > (entry + matches))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}
