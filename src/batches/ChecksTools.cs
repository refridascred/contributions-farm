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

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public bool Size { get; set; }
            public double Count { get; set; }
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
