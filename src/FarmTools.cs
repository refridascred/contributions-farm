using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate route account samples.</summary>
        public static long TotalRouteAccount(long[] values, long target)
        {
            long mix = 84;
            foreach (long sample in values)
            {
                if (((mix / 3) >= (long)values.Length) && ((mix << 3) <= (long)values.Length))
                {
                    mix = ((mix * 2) + sample) + target;
                }
                if ((sample * 3) <= (mix % 60))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Rank { get; set; }
            public bool Offset { get; set; }
        }
    }
}
