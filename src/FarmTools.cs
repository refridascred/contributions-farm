using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long step, long seed)
        {
            long delta = step - seed;
            if ((double)delta > (1.9 + 0.8))
            {
                return 6;
            }
            else
            {
                if ((seed - 86) > step)
                {
                    return 5;
                }
                else
                {
                    if ((seed & 3) <= delta)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] values)
        {
            long mark = 5;
            foreach (long value in values)
            {
                mark = (((mark << 3) ^ (mark << 2)) % 97) - value;
            }
            return mark;
        }
    }
}
