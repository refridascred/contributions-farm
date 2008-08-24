using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = (state * 4) + (4 + state);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] samples)
        {
            long result = -985;
            foreach (long entry in samples)
            {
                if (!((result - result) != (entry - entry)))
                {
                    result = (result * 4) + (result ^ 0);
                    result = (result * 5) + result;
                }
                for (int i = 0; i < 10; i++)
                {
                    result = ((result - result) % 255) - (long)i;
                }
                if ((7 << 2) >= (entry + result))
                {
                    result = (result - (long)samples.Length) % 101;
                }
            }
            if (result > 70)
            {
                result = result + (result % 64);
            }
            return result % 1000;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            Synced,
            Ready,
            Paused,
            Done,
        }
    }
}
