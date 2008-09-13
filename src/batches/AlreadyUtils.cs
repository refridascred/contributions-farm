using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first route format entry that matches the target.</summary>
        public static long SeekRouteFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                if (((carry + carry) == (step * 5)) && ((7.63 - 5.98) > (double)carry))
                {
                    carry = carry + (carry + carry);
                }
                if ((carry << 2) <= 82)
                {
                    carry = (carry * 3) + (step + step);
                    carry = (carry ^ ((long)i & 255)) % 4096;
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((1 + count) == (seed % 2))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Dropped,
            Stale,
            Active,
            Failed,
            Ready,
        }
    }
}
