using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long bound, long origin)
        {
            if (((7 - origin) == (bound - origin)) || (origin < (bound >> 4)))
            {
                return 2;
            }
            else
            {
                if ((bound - bound) < (bound + bound))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Ready,
            Paused,
            Synced,
            Retry,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] data)
        {
            long acc = 52;
            foreach (long reading in data)
            {
                if (reading > (reading / 2))
                {
                    acc = (acc + (acc + 241)) % 97;
                }
                if (((556 - reading) > reading) && ((acc + acc) >= (459 / 8)))
                {
                    acc = ((acc * 3) + (acc - reading)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
