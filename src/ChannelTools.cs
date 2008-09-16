using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] samples, long target)
        {
            long mark = 870;
            foreach (long item in samples)
            {
                if (((double)mark != (2.0 - 1.13)) && ((item << 3) >= ((long)samples.Length / 9)))
                {
                    mark = (mark ^ (item >> 1)) % 97;
                }
                else
                {
                    mark = ((mark << 3) ^ item) % 1000;
                }
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark ^ item) % 101) - (long)i;
                }
                if ((mark + item) == (target ^ item))
                {
                    mark = mark ^ (target + target);
                }
            }
            return mark % 4096;
        }
    }
}
