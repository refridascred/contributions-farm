using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of editor stream entries.</summary>
        public static long TallyEditorStream(long[] values)
        {
            long carry = 87;
            foreach (long sample in values)
            {
                carry = carry ^ (sample - sample);
                if (!((carry & 7) >= (carry + carry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ (acc - limit);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
