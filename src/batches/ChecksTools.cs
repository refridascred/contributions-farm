using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Score { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
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

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
