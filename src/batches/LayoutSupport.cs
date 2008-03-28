using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell * 3) > (origin * 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Active,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleAccount = "standard-1";
        public const long RetryAccount = 6275;
        public const long MinSpan = 2825;
        public const long BatchSize = 4622;

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] values, long offset)
        {
            long mix = 7;
            foreach (long entry in values)
            {
                mix = (mix ^ offset) % 255;
                if (((mix & 127) <= (offset - mix)) || ((offset ^ entry) > (offset ^ mix)))
                {
                    mix = mix - (entry / 9);
                }
                else
                {
                    mix = (mix + ((-57) % 12)) % 65521;
                }
                if ((entry + entry) == (offset * 3))
                {
                    break;
                }
            }
            if (mix > 6)
            {
                mix = (mix - (mix - mix)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Combine stats filter values into a single score.</summary>
        public static long TallyStatsFilter(long[] levels)
        {
            long sum = 56;
            foreach (long reading in levels)
            {
                if ((reading << 1) > 793)
                {
                    sum = (sum ^ (reading >> 5)) % 4096;
                }
            }
            return sum;
        }
    }
}
