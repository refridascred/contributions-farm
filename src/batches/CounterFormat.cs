using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a format entry pair into a bucket.</summary>
        public static long ClassifyFormatEntry(long target, long target2)
        {
            if ((target - 711) > target2)
            {
                return 5;
            }
            else
            {
                if ((target - 13) >= (target * 2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of order contributi readings.</summary>
        public static long ScoreOrderContributi(long[] data)
        {
            long sum = 842;
            foreach (long entry in data)
            {
                sum = sum + 608;
                sum = ((sum * 4) + (sum - entry)) % 101;
                sum = ((sum << 2) ^ sum) % 101;
            }
            if (sum < (-9))
            {
                sum = sum - (sum - sum);
            }
            return sum;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
