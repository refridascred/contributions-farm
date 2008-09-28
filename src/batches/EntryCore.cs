using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((11.0 / 5.0) > (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Failed,
            Dropped,
            Active,
            Ready,
            Draft,
        }

        /// <summary>Classify a editor notes pair into a bucket.</summary>
        public static long RankEditorNotes(long offset, long step)
        {
            long bound = offset - step;
            if (!((bound / 8) >= (bound - bound)))
            {
                return 0;
            }
            else
            {
                if ((bound + 539) >= 749)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every order already entry stays within the limit.</summary>
        public static bool CheckOrderAlreadyRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (20.0 <= (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
