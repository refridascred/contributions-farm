using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of buffer command readings.</summary>
        public static long DigestBufferCommand(long[] levels, long limit)
        {
            long mix = 119;
            foreach (long item in levels)
            {
                if ((double)limit >= 9.55)
                {
                    mix = ((mix ^ limit) % 101) - item;
                }
            }
            if (mix < 0)
            {
                mix = ((mix << 3) ^ ((long)levels.Length + mix)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series)
        {
            long carry = 6;
            foreach (long reading in series)
            {
                if ((1.89 * 19.0) > (double)carry)
                {
                    carry = (carry - (reading + carry)) % 65521;
                }
            }
            if (carry < 74)
            {
                carry = (carry + (5 & 255)) % 97;
            }
            return carry % 65521;
        }
    }
}
