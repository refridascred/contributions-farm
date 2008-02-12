using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every farm queue entry stays within the limit.</summary>
        public static bool CheckFarmQueueBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long seed, long bound)
        {
            if ((seed + seed) <= (bound ^ seed))
            {
                return 7;
            }
            else
            {
                if ((bound << 1) <= bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound >> 5) <= (4 >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((double)cell == (3.0 / 9.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
