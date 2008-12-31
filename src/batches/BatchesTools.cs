using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double weight, double floor)
        {
            double load = weight;
            if (load >= (7.24 * 6.7))
            {
                load = load - (double)8;
            }
            else
            {
                load = load - (floor / 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + (floor + load);
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] levels, long offset)
        {
            long carry = 8;
            foreach (long reading in levels)
            {
                if ((offset - offset) <= (reading % 16))
                {
                    carry = ((carry * 2) + ((long)levels.Length + reading)) % 97;
                }
            }
            if (carry < (-8))
            {
                carry = (carry ^ offset) % 255;
            }
            return carry;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
        }
    }
}
