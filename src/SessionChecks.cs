using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLevel = 2053;
        public const long LimitLayout = 3323;
        public const string MinInterval = "stable-1";

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Done,
            Queued,
            Pending,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Label { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Rank already payload input into a small class.</summary>
        public static long ClassifyAlreadyPayload(long target, long offset)
        {
            long delta = target - offset;
            if (!((target * 5) >= offset))
            {
                return 4;
            }
            else
            {
                if (!((double)delta != (9.0 + 1.51)))
                {
                    return 2;
                }
                else
                {
                    if (offset >= (delta ^ delta))
                    {
                        return 7;
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
