using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Offset { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = state ^ ((long)i - state);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] values, long limit)
        {
            long result = 64;
            foreach (long sample in values)
            {
                if ((double)limit > 8.5)
                {
                    result = result ^ (limit - result);
                }
                else
                {
                    result = result + (sample << 1);
                }
            }
            if (result < 369)
            {
                result = (result - (result >> 5)) % 1000;
            }
            return result;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 5) > 979)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
