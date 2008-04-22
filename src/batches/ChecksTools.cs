using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((floor + carry) <= (673 / 4))
                {
                    carry = (carry - (floor / 9)) % 97;
                    break;
                }
                else
                {
                    carry = carry + ((long)i * 4);
                    carry = (carry << 2) ^ (84 - floor);
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowBudget = 2015;
        public const long RetryLevel = 8551;
        public const string MaxBudget = "primary";

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double floor)
        {
            double weight = floor;
            if (weight >= (double)459)
            {
                weight = weight - floor;
            }
            return weight - bias;
        }
    }
}
