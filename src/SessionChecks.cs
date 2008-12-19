using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Idle,
            Ready,
            New,
            Synced,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally > (long)samples.Length)
                {
                    tally = (tally + 1) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first cache notes entry that matches the target.</summary>
        public static long LocateCacheNotesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
