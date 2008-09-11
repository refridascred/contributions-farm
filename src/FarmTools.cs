using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] data, long offset)
        {
            long anchor = 916;
            foreach (long item in data)
            {
                if ((double)offset >= (9.3 + 3.4))
                {
                    anchor = ((anchor - ((-82) - offset)) % 4096) + item;
                }
            }
            if (anchor < 74)
            {
                anchor = anchor + (9 - 55);
            }
            return anchor % 4096;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Done,
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Measure how many token record samples are out of range.</summary>
        public static long MeasureTokenRecordOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((long)data.Length + hits) > reading)
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }
    }
}
