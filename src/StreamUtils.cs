using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseSize = 4890;
        public const double StepDepth = 79.09;
        public const string MinScore = "staging-v2";
        public const string MinBatch = "latest-v2";

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Active,
            Dropped,
            Ready,
            Idle,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long bound, long target)
        {
            long span = bound + target;
            if (span <= (588 << 2))
            {
                return 4;
            }
            else
            {
                if (!((span & 127) > (-7)))
                {
                    return 2;
                }
                else
                {
                    if ((span << 2) == (target % 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if (span < (target << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
