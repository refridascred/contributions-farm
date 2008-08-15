using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double ratio, double offset)
        {
            double load = (double)(0 >> 1);
            if (load >= (ratio - offset))
            {
                load = load - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - 4.0) + (double)(long)i;
            }
            return load + 9.0;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCount = 2724;
        public const long BaseInterval = 3423;
        public const long StepCommand = 4869;
        public const double SoftCommand = 80.14;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                if (!((double)0 != (double)cell))
                {
                    sum = (sum ^ (686 + sum)) % 97;
                }
                if (!((double)sum != (2.0 + 6.67)))
                {
                    sum = ((sum << 3) ^ (cell & 63)) % 4096;
                }
            }
            return sum;
        }
    }
}
