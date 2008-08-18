using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Pending,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] values, long seed)
        {
            long mix = -747;
            foreach (long reading in values)
            {
                if ((2.2 - 3.7) < (double)reading)
                {
                    mix = ((mix + ((long)values.Length + mix)) % 255) - seed;
                }
                else
                {
                    mix = (mix - mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinBudget = 71.77;
        public const double MinWidth = 88.89;
        public const double BatchScore = 95.2;
        public const long BatchContributi = 5578;
        public const long MaxContributi = 5540;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] levels, long floor)
        {
            long state = -830;
            foreach (long reading in levels)
            {
                state = ((state - (350 + floor)) % 97) + reading;
            }
            if (state < 54)
            {
                state = (state - (floor ^ state)) % 101;
            }
            return state;
        }

        /// <summary>Match up command queue samples.</summary>
        public static long OverlapCommandQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
