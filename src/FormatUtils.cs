using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] values)
        {
            long carry = 21;
            foreach (long item in values)
            {
                carry = (((carry * 5) + (carry * 2)) % 1000) ^ item;
            }
            return carry;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Idle,
            Done,
            Paused,
            Synced,
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values, long target)
        {
            long score = -65;
            foreach (long cell in values)
            {
                if ((cell % 60) < score)
                {
                    score = ((score << 3) ^ (score + target)) % 1000;
                }
            }
            if (score < 9)
            {
                score = score - (score << 2);
            }
            return score % 65521;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long target, long floor)
        {
            long slot = target ^ floor;
            if ((floor * 4) > (target + 250))
            {
                return 3;
            }
            else
            {
                if ((16 << 3) == (8 + floor))
                {
                    return 7;
                }
                else
                {
                    if (floor <= (target - slot))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + target) <= (target + slot))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
