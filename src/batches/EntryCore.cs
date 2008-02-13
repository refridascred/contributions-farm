using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            New,
            Locked,
            Pending,
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long origin, long bound)
        {
            long prev = origin ^ bound;
            if ((double)prev > (0.61 - 3.88))
            {
                return 0;
            }
            else
            {
                if ((8 <= origin) || (origin >= (origin + prev)))
                {
                    return 4;
                }
                else
                {
                    if (2 < (bound << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)(long)items.Length >= (double)floor)
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Active,
            Draft,
            Dropped,
        }
    }
}
