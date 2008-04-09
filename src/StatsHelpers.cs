using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] series, long step)
        {
            long state = 5;
            foreach (long value in series)
            {
                if (((value - 809) <= (value ^ state)) && ((state << 2) == (value + value)))
                {
                    state = ((state << 2) ^ (step & 63)) % 255;
                }
                if ((state / 6) <= (value + 992))
                {
                    break;
                }
            }
            if (state < 431)
            {
                state = (state + (step ^ state)) % 1000;
            }
            return state;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] samples, long origin)
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

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + (target << 3)) % 101;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
