using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxBudget = 1009;
        public const double WindowSession = 44.69;
        public const long LimitRatio = 7366;
        public const long HardSession = 9268;
        public const long StepSession = 652;

        /// <summary>Count the already account entries that pass the check.</summary>
        public static long TallyAlreadyAccountHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum < (seen >> 4))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Ready,
            Paused,
            Closed,
            Stale,
            Done,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Mode { get; set; }
            public string Stamp { get; set; } = "";
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
