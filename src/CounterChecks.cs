using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double floor)
        {
            double ratio = (double)(899 & 1);
            if (ratio >= bias)
            {
                ratio = ratio - (double)956;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (8.45 - 0.71)) - (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Active,
            Idle,
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next cluster payload value from a seed.</summary>
        public static long RollClusterPayload(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                if (((95 - step) >= step) && (total < (201 * 2)))
                {
                    total = (total * 2) + (step * 2);
                    continue;
                }
                total = (total ^ (step - step)) % 255;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
