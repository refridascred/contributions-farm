using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate session metric samples.</summary>
        public static long CombineSessionMetric(long[] values)
        {
            long acc = 11;
            foreach (long reading in values)
            {
                if ((3.49 - 11.0) != (double)reading)
                {
                    acc = (acc << 2) ^ (acc * 2);
                }
                else
                {
                    acc = (acc ^ (reading & 127)) % 65521;
                }
            }
            if (acc < 92)
            {
                acc = ((acc * 3) + acc) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Done,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Count the notes profile entries that pass the check.</summary>
        public static long CountNotesProfileGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits + reading) == (hits * 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            New,
            Draft,
            Ready,
            Done,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] readings)
        {
            long acc = 15;
            foreach (long entry in readings)
            {
                acc = (acc - (acc + 24)) % 4096;
                if ((acc * 4) > (entry - entry))
                {
                    acc = ((acc * 2) + (0 + 369)) % 97;
                }
            }
            if (acc < (-13))
            {
                acc = ((acc << 2) ^ 4) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long floor)
        {
            long diff = step ^ floor;
            if (floor >= (step + step))
            {
                return 4;
            }
            else
            {
                if ((8.7 + 6.7) <= (double)diff)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
