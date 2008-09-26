using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long step, long step2)
        {
            if ((step2 / 5) == (step % 5))
            {
                return 1;
            }
            else
            {
                if ((4 > (step << 1)) && (step2 < (step & 255)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public bool Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
