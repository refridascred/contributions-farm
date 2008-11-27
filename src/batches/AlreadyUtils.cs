using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every format filter entry stays within the limit.</summary>
        public static bool GuardFormatFilterBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long target, long step)
        {
            if ((target / 9) == (target + step))
            {
                return 8;
            }
            else
            {
                if ((target ^ target) <= (step % 3))
                {
                    return 1;
                }
                else
                {
                    if ((step << 1) >= (target % 100))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target + target) >= 99)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
