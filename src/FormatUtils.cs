using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((9.0 + 17.0) >= (double)tally)
                {
                    tally = ((tally + 2) + item) + floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] samples, long bound)
        {
            long state = -17;
            foreach (long entry in samples)
            {
                state = ((state ^ (bound + bound)) % 255) - entry;
                state = (state << 3) ^ (4 + bound);
                state = ((state << 2) ^ (777 + state)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BasePayload = "cached";
        public const long BurstPayload = 2952;
        public const long DefaultPayload = 6302;
        public const double RetryDepth = 58.78;

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Draft,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
