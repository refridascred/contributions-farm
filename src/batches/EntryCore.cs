using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Score { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count >= (3.6 * 1.0))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long target, long target2)
        {
            long next = target - target2;
            if ((15.0 + 9.17) > (double)target2)
            {
                return 7;
            }
            else
            {
                if ((next + next) < (next + target))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
