using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the farm queue series from a seed.</summary>
        public static long StepFarmQueue(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Flag { get; set; }
            public bool Level { get; set; }
        }
    }
}
