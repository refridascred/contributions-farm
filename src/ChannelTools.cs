using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a payload counter value against two limits.</summary>
        public static long RankPayloadCounter(long offset, long seed)
        {
            if (((6.32 / 6.0) > (double)seed) || ((offset ^ offset) == (offset & 3)))
            {
                return 4;
            }
            else
            {
                if ((double)seed > (5.8 - 0.6))
                {
                    return 2;
                }
                else
                {
                    if (!((double)offset != (20.0 * 4.3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0.44 > (double)offset) || (seed < (offset - offset)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Done,
            Idle,
        }
    }
}
