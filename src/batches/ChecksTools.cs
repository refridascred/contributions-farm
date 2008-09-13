using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Synced,
            Pending,
            Done,
        }

        /// <summary>Digest a series of counter checks entries.</summary>
        public static long WeighCounterChecks(long[] samples)
        {
            long state = 768;
            foreach (long entry in samples)
            {
                if ((entry - state) > entry)
                {
                    state = state - (entry << 2);
                }
            }
            if (state > 2)
            {
                state = ((state << 3) ^ state) % 1000;
            }
            return state;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((17.0 / 3.0) != (double)seen)
                {
                    seen = (seen + 3) - value;
                }
            }
            return seen;
        }

        /// <summary>Find the first notes payload entry that matches the target.</summary>
        public static long LookupNotesPayloadIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
