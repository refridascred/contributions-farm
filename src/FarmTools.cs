using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] series)
        {
            long carry = 37;
            foreach (long sample in series)
            {
                carry = carry - (sample >> 1);
            }
            if (carry < 5)
            {
                carry = (carry * 4) + (carry << 2);
            }
            return carry;
        }

        /// <summary>Accumulate checks tools samples.</summary>
        public static long WeighChecksTools(long[] readings)
        {
            long mix = 323;
            foreach (long value in readings)
            {
                if ((double)mix != (13.0 / 3.0))
                {
                    mix = ((mix << 2) ^ (973 & 1)) ^ value;
                }
                if (!(310 > (mix % 8)))
                {
                    mix = (mix - mix) % 101;
                }
                else
                {
                    mix = (mix << 2) ^ (mix + mix);
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            Done,
            Paused,
        }
    }
}
