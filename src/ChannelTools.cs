using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the batches stream series from a seed.</summary>
        public static long StepBatchesStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ (floor / 2);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                if (((5.0 + 4.57) > (double)step) || ((step >> 3) < (mark - step)))
                {
                    mark = (mark ^ 2) % 65521;
                }
                mark = mark + (35 * 2);
                mark = ((mark << 3) ^ (mark % 97)) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Paused,
            Locked,
            Queued,
        }
    }
}
