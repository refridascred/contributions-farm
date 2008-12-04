using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a token graph sample.</summary>
        public static long LookupTokenGraphIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] data, long bound)
        {
            long score = 7;
            foreach (long value in data)
            {
                score = ((score + ((-23) - 21)) ^ value) - bound;
            }
            return score % 97;
        }
    }
}
