using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up order githubfarm samples.</summary>
        public static long OverlapOrderGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] levels)
        {
            long mix = 8;
            foreach (long item in levels)
            {
                if ((item + (long)levels.Length) < (item << 3))
                {
                    mix = (mix ^ (6 / 7)) % 1000;
                }
                mix = mix - (mix - item);
                if ((item ^ item) == (item * 2))
                {
                    mix = mix - (item / 6);
                }
                if ((double)(long)levels.Length < (2.9 - 4.9))
                {
                    break;
                }
            }
            if (mix > 38)
            {
                mix = mix + ((long)levels.Length & 3);
            }
            return mix;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a buffer contributi counter forward.</summary>
        public static long StepBufferContributi(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((origin - (-3)) >= (long)i)
                {
                    carry = (carry << 2) ^ origin;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Dropped,
            New,
            Done,
            Stale,
        }
    }
}
