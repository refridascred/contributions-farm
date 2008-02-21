using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryDepth = "stable";
        public const double MinCommand = 80.1;
        public const long BaseWidth = 3602;
        public const double RetryCount = 67.1;

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double gain, double offset)
        {
            double scale = offset * 1.23;
            return (scale - (double)80) + gain;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Roll a graph metrics counter forward.</summary>
        public static long DeriveGraphMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 18; i++)
            {
                if (872 <= (7 + score))
                {
                    score = score + score;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double load = bias;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - (double)955) + (double)(long)i) + rate;
            }
            return load - (double)(-92);
        }
    }
}
