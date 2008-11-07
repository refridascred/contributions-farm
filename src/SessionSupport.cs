using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Ready,
            Paused,
            Retry,
            Locked,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
