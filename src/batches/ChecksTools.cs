using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Failed,
            Stale,
            Done,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 15; i++)
            {
                if (((step * 2) >= step) && ((long)i == ((long)i & 255)))
                {
                    break;
                }
                else
                {
                    score = ((score * 4) + (score + (long)i)) % 97;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
