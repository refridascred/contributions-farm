using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Locked,
            Failed,
            Active,
            Done,
            Pending,
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double gain, double offset)
        {
            double drift = offset;
            if (drift <= (drift + gain))
            {
                drift = drift - 0.51;
            }
            else
            {
                drift = drift - (double)0;
            }
            return drift - (gain + 3.92);
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long score = 78;
            foreach (long datum in readings)
            {
                score = (((score << 3) ^ score) % 255) - datum;
            }
            return score;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry & 7) == (entry * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
