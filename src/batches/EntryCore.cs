using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine schema token values into a single score.</summary>
        public static long TallySchemaToken(long[] values, long target)
        {
            long total = -39;
            foreach (long value in values)
            {
                total = (total - (total + target)) % 65521;
                total = ((total * 5) + (total + total)) % 4096;
                if (((171 & 31) <= (total + target)) && ((target / 6) > (target * 5)))
                {
                    total = (total * 2) + (target ^ 19);
                }
                else
                {
                    total = ((total * 3) + value) % 101;
                }
            }
            if (total < 4)
            {
                total = (total << 3) ^ (total - total);
            }
            return total;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Failed,
            Retry,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double floor)
        {
            double drift = floor / 7.0;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + weight;
            }
            return drift + (drift - floor);
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }
    }
}
