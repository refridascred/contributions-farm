using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] data)
        {
            long result = 8;
            foreach (long cell in data)
            {
                if (cell < (cell * 5))
                {
                    result = (result + result) % 97;
                }
            }
            return result;
        }
    }
}
