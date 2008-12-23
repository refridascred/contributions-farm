using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long offset, long floor)
        {
            long bound = offset - floor;
            if ((floor + 9) != (floor + bound))
            {
                return 1;
            }
            else
            {
                if (floor >= offset)
                {
                    return 4;
                }
                else
                {
                    if (((offset ^ floor) <= (4 << 3)) || ((floor ^ offset) <= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((offset + offset) <= offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Match up support window samples.</summary>
        public static long PairSupportWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
