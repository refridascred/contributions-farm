using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double bias, double offset)
        {
            double mean = (double)(323 + 5);
            if (mean >= 0.31)
            {
                mean = (mean - bias) - offset;
            }
            else
            {
                mean = mean - (mean - mean);
            }
            return mean - (double)27;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
