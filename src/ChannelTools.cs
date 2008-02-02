using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a batches notes value against two limits.</summary>
        public static long RankBatchesNotes(long origin, long offset)
        {
            long step = origin + offset;
            if ((double)origin < 8.39)
            {
                return 3;
            }
            else
            {
                if ((4 - origin) >= 618)
                {
                    return 5;
                }
                else
                {
                    if ((step / 3) >= (step << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (99 >= (step & 255))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
