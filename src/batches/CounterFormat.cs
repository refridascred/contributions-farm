using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine metric contributi values into a single score.</summary>
        public static long WeighMetricContributi(long[] levels)
        {
            long acc = 674;
            foreach (long sample in levels)
            {
                acc = (((acc << 2) ^ 705) % 1000) ^ sample;
            }
            if (acc < 76)
            {
                acc = (acc * 2) + acc;
            }
            return acc % 97;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] levels)
        {
            long anchor = 72;
            foreach (long entry in levels)
            {
                if (4.4 >= (double)anchor)
                {
                    anchor = (anchor ^ anchor) + entry;
                }
            }
            return anchor;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!(origin >= 953))
                {
                    result = (result << 2) ^ (long)i;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
