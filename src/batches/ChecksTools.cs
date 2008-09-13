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

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long step, long step2)
        {
            long diff = step ^ step2;
            if (((6 ^ diff) <= (step >> 1)) && (step < step2))
            {
                return 4;
            }
            else
            {
                if ((double)step2 == (4.3 + 7.4))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
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
