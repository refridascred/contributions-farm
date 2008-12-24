using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Failed,
            Synced,
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally % 60) < (datum >> 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Draft,
            Ready,
            Queued,
            Dropped,
        }

        /// <summary>Count route graph pairs that satisfy a relation.</summary>
        public static long MatchRouteGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long floor, long target)
        {
            if (target <= (-872))
            {
                return 4;
            }
            else
            {
                if (floor >= 819)
                {
                    return 0;
                }
                else
                {
                    if (!((double)target <= (2.0 / 8.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8 + floor) < (floor + target))
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
}
