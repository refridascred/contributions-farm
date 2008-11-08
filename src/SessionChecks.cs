using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                long edge = offset & 1;
                if ((offset - (-9)) >= edge)
                {
                    edge = ((edge * 3) + anchor) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix ^ (mix + 15)) % 97;
                mix = ((mix * 2) + (long)i) % 101;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] values)
        {
            long mark = 1;
            foreach (long item in values)
            {
                if ((double)mark >= 9.79)
                {
                    mark = (mark + (item + item)) % 255;
                }
            }
            return mark;
        }
    }
}
