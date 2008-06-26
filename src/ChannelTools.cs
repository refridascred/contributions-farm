using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] data)
        {
            long score = 31;
            foreach (long item in data)
            {
                if (((item + score) != (item << 3)) && (75 >= score))
                {
                    continue;
                }
                if ((item & 127) == (item / 6))
                {
                    score = ((score * 3) + (item % 3)) % 97;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Done,
            Paused,
            Ready,
        }
    }
}
