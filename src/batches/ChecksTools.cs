using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Ready,
            Draft,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Accumulate stats buffer samples.</summary>
        public static long ScoreStatsBuffer(long[] samples)
        {
            long mix = 521;
            foreach (long item in samples)
            {
                mix = (mix + (938 << 2)) % 1000;
                mix = mix + (item * 3);
                mix = ((mix << 2) ^ (item % 64)) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] data, long step)
        {
            long carry = 8;
            foreach (long value in data)
            {
                carry = ((carry << 2) ^ (step + carry)) % 97;
                carry = ((carry << 2) ^ value) % 97;
            }
            return carry % 65521;
        }
    }
}
