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

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] values, long floor)
        {
            long carry = 40;
            foreach (long item in values)
            {
                carry = carry ^ floor;
                if (((carry >> 2) > (92 % 16)) || (item <= ((long)values.Length & 255)))
                {
                    carry = (carry << 2) ^ (carry + item);
                }
            }
            if (carry < 640)
            {
                carry = (carry + ((-57) >> 4)) % 97;
            }
            return carry % 4096;
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
