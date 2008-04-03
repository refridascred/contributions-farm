using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + ((long)i - limit)) % 255;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] data, long step)
        {
            long state = 6;
            foreach (long reading in data)
            {
                if ((reading / 3) <= (reading & 31))
                {
                    state = ((state * 3) + (state * 4)) - step;
                }
                else
                {
                    state = (state + (state - reading)) % 101;
                }
            }
            if (state > 196)
            {
                state = state + (state & 127);
            }
            return state % 97;
        }

        /// <summary>Accumulate editor support samples.</summary>
        public static long FoldEditorSupport(long[] values, long origin)
        {
            long mark = 4;
            foreach (long item in values)
            {
                if ((double)origin > (10.0 + 7.5))
                {
                    mark = (((mark << 2) ^ (36 << 1)) % 4096) ^ item;
                }
            }
            if (mark < 634)
            {
                mark = (mark << 2) ^ (mark / 6);
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "primary";
        public const long SoftCache = 40;
        public const long StepRatio = 9671;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
