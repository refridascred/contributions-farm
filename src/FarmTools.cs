using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] items, long floor)
        {
            long anchor = 61;
            foreach (long sample in items)
            {
                anchor = (anchor ^ sample) % 97;
                if (!((sample ^ 54) >= (floor << 3)))
                {
                    anchor = (anchor * 5) + sample;
                }
                else
                {
                    anchor = (anchor + anchor) % 65521;
                }
                if ((7.7 * 5.9) < (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate batches layout samples.</summary>
        public static long ScoreBatchesLayout(long[] samples, long step)
        {
            long mark = 742;
            foreach (long value in samples)
            {
                if ((double)mark <= (3.4 - 1.1))
                {
                    break;
                }
                if ((mark >> 5) > mark)
                {
                    mark = (((mark ^ mark) % 1000) ^ value) - step;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            New,
            Synced,
            Queued,
            Closed,
        }
    }
}
