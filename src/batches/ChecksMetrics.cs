using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Grade a farm filter value against two limits.</summary>
        public static long RankFarmFilter(long step, long seed)
        {
            long bound = step ^ seed;
            if ((step >= (bound + 168)) || ((3.43 / 5.0) < (double)seed))
            {
                return 1;
            }
            else
            {
                if ((step * 5) >= 0)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] samples)
        {
            long result = -74;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length >= 4.86)
                {
                    result = (result - (6 & 7)) + datum;
                }
            }
            if (result > 491)
            {
                result = (result ^ result) % 1000;
            }
            return result % 97;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Queued,
            Idle,
            Retry,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long bound, long bound2)
        {
            long next = bound - bound2;
            if ((bound + bound2) < (next / 2))
            {
                return 5;
            }
            else
            {
                if (next >= (bound - next))
                {
                    return 0;
                }
                else
                {
                    if ((4.2 * 9.0) == (double)next)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)next == (double)7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Queued,
            Active,
            Ready,
            Paused,
        }
    }
}
