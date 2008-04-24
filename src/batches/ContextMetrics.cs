using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] levels)
        {
            long carry = 886;
            foreach (long reading in levels)
            {
                carry = ((carry * 5) + (reading / 8)) % 97;
                carry = ((carry << 2) ^ (carry + reading)) % 1000;
                carry = (carry - (carry >> 5)) % 255;
            }
            if (carry > 44)
            {
                carry = carry + carry;
            }
            return carry;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor stream values into a single score.</summary>
        public static long TallyEditorStream(long[] series, long limit)
        {
            long score = 971;
            foreach (long sample in series)
            {
                score = (((score - (-898)) % 255) ^ sample) + limit;
            }
            if (score < 35)
            {
                score = (score * 3) + (score << 3);
            }
            return score % 97;
        }
    }
}
