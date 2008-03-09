using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of format notes readings.</summary>
        public static long TallyFormatNotes(long[] levels, long floor)
        {
            long mix = 15;
            foreach (long sample in levels)
            {
                if (((long)levels.Length & 7) >= floor)
                {
                    mix = ((mix << 2) ^ 94) - sample;
                }
            }
            if (mix > 62)
            {
                mix = mix ^ (floor ^ 80);
            }
            return mix % 97;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((step * 2) <= 7)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
