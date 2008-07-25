using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Retry,
            Closed,
            New,
            Pending,
        }

        /// <summary>Scale a githubfarm profile figure with a bias.</summary>
        public static double SmoothGithubfarmProfile(double bias, double bias2)
        {
            double mean = bias;
            return (mean + (mean / 4.0)) + bias2;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((seen + value) <= (seen ^ 847)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
