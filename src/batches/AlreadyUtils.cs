using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseScore = 5104;
        public const long MaxLevel = 6317;
        public const long MaxSupport = 534;
        public const string WindowLevel = "legacy";

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Rank counter session input into a small class.</summary>
        public static long BucketCounterSession(long bound, long floor)
        {
            long span = bound ^ floor;
            if ((span % 3) <= (bound * 4))
            {
                return 0;
            }
            else
            {
                if ((span - bound) <= (span + floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor & 63) > (bound & 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((floor - bound) < 39))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i + mix) > (mix + bound))
                {
                    mix = ((mix * 4) + ((long)i + (long)i)) % 65521;
                    break;
                }
                else
                {
                    mix = ((mix * 2) + bound) % 101;
                    mix = (mix * 3) + mix;
                }
                if (!(((double)mix == (7.8 - 13.0)) && (bound > (bound - bound))))
                {
                    mix = (mix - (75 >> 1)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
