using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long seed, long step)
        {
            long offset = seed ^ step;
            if ((5.85 + 2.6) == (double)step)
            {
                return 0;
            }
            else
            {
                if (seed < (seed << 2))
                {
                    return 3;
                }
                else
                {
                    if (!(offset < (step & 255)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed + 894) >= step) && ((double)1 >= (double)step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            New,
            Failed,
            Paused,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Draft,
            Queued,
            Done,
            New,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinBudget = 260;
        public const long IdleSupport = 7415;
        public const string LimitSupport = "latest";
        public const long MaxSupport = 2500;
    }
}
