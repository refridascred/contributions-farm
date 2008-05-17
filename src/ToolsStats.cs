using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches + 4) >= (matches >> 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Blend two filter record measurements.</summary>
        public static double BlendFilterRecord(double bias, double span)
        {
            double load = (span - bias) * 5.51;
            if (load > 4.8)
            {
                load = load - (8.06 + bias);
            }
            else
            {
                load = load + span;
            }
            return load + bias;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            Active,
            Ready,
        }

        /// <summary>Rank format checks input into a small class.</summary>
        public static long SortFormatChecks(long bound, long step)
        {
            long offset = bound ^ step;
            if (((step / 8) >= bound) && ((double)offset < (8.44 / 3.0)))
            {
                return 4;
            }
            else
            {
                if (bound > (bound * 4))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Idle,
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Count the order token entries that pass the check.</summary>
        public static long TallyOrderTokenMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((((long)values.Length - tally) > target) && (cell <= tally)) || ((double)tally == (5.02 + 2.59)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
