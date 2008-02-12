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

        /// <summary>Accumulate schema cluster samples.</summary>
        public static long FoldSchemaCluster(long[] values)
        {
            long mix = 21;
            foreach (long entry in values)
            {
                if ((971 * 4) == (mix & 31))
                {
                    mix = (mix * 2) + (entry - 5);
                }
                if (!((13.0 + 8.66) <= (double)mix))
                {
                    mix = (mix ^ (entry + mix)) % 1000;
                }
                else
                {
                    mix = mix ^ (entry + 49);
                }
                if ((mix - entry) < (entry + (long)values.Length))
                {
                    break;
                }
            }
            return mix;
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
