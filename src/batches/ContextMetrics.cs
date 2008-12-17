using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long target, long floor)
        {
            if ((target >> 3) <= (floor + target))
            {
                return 3;
            }
            else
            {
                if (((target & 63) >= (target - target)) || ((0.54 + 10.0) > (double)floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor < (19.0 / 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + target) != (target % 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a editor graph reading by value.</summary>
        public static long FindEditorGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Locked,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            Paused,
            Queued,
        }
    }
}
