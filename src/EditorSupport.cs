using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the queue schema series from a seed.</summary>
        public static long RollQueueSchema(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                if ((anchor + anchor) == ((long)i - step))
                {
                    anchor = (anchor << 3) ^ (723 >> 5);
                    anchor = anchor ^ step;
                }
                anchor = (anchor ^ (anchor / 8)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 4253;
        public const long DefaultDepth = 4476;
        public const double SoftBuffer = 72.12;
        public const string WindowFactor = "stable-edge";

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Ready,
            Active,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryBudget = 2714;
        public const double BatchInterval = 87.13;
        public const double CacheTools = 20.73;
        public const string CacheSpan = "standard-1";
        public const long BurstSize = 4833;
    }
}
