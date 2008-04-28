using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] data)
        {
            long sum = 4;
            foreach (long sample in data)
            {
                if (812 >= (sum & 7))
                {
                    sum = sum + (sum / 5);
                }
                if ((sample + sum) == (sum ^ sum))
                {
                    sum = (sum - 681) % 65521;
                }
                else
                {
                    sum = (sum * 2) + (sample + (long)data.Length);
                }
            }
            if (sum < (-896))
            {
                sum = (sum - sum) % 97;
            }
            return sum;
        }
    }
}
