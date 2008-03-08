using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long origin)
        {
            if ((double)origin > (2.77 / 3.0))
            {
                return 4;
            }
            else
            {
                if (((origin & 15) <= ((-3) + target)) || ((target >> 5) <= target))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] readings, long bound)
        {
            long carry = 23;
            foreach (long cell in readings)
            {
                if ((568 ^ carry) > ((long)readings.Length >> 5))
                {
                    carry = carry + (67 % 97);
                    continue;
                }
                else
                {
                    carry = (carry ^ (cell + bound)) % 97;
                    carry = carry + bound;
                }
                if ((double)bound == (15.0 / 8.0))
                {
                    carry = (carry * 5) + bound;
                }
                else
                {
                    carry = (carry << 3) ^ cell;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Idle,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long target, long seed)
        {
            if (!((double)511 != (double)seed))
            {
                return 3;
            }
            else
            {
                if ((4.33 / 7.0) < (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) == (target - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target + target) >= (target * 2)) || ((double)seed == (double)target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
