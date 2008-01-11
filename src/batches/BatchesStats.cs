using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] readings)
        {
            long result = 30;
            foreach (long sample in readings)
            {
                if ((double)sample <= 2.01)
                {
                    result = (result << 3) ^ (result - result);
                }
                result = (result + result) % 65521;
                if (((double)result >= (9.0 * 9.78)) || ((6 / 9) > (result / 3)))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of payload farm entries.</summary>
        public static long DigestPayloadFarm(long[] values, long target)
        {
            long state = 528;
            foreach (long entry in values)
            {
                if (!((double)state >= (1.81 * 5.4)))
                {
                    state = ((state * 4) + (1 + 56)) + target;
                }
                else
                {
                    state = (state * 3) + (entry + state);
                }
            }
            if (state > 4)
            {
                state = (state ^ 3) % 101;
            }
            return state;
        }

        /// <summary>Locate a filter record reading by value.</summary>
        public static long LocateFilterRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
