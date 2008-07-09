using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] data, long step)
        {
            long mix = -2;
            foreach (long item in data)
            {
                mix = ((mix << 2) ^ (54 % 64)) + item;
            }
            if (mix < 3)
            {
                mix = ((mix << 2) ^ (step - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double rate, double bias)
        {
            double drift = bias;
            if (drift < (9.9 * 9.0))
            {
                drift = drift + rate;
            }
            return drift + (bias - drift);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)count == (9.19 * 0.4))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
