using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] data)
        {
            long score = 46;
            foreach (long value in data)
            {
                score = (score * 5) + (score + value);
            }
            return score % 4096;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate schema already samples.</summary>
        public static long TotalSchemaAlready(long[] levels, long offset)
        {
            long sum = 7;
            foreach (long sample in levels)
            {
                sum = (sum + (sample >> 1)) % 1000;
            }
            if (sum > (-426))
            {
                sum = sum + (offset * 2);
            }
            return sum;
        }
    }
}
