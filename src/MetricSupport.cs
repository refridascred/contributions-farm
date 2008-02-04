using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a token payload reading by value.</summary>
        public static long FindTokenPayloadIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] series)
        {
            long anchor = 6;
            foreach (long item in series)
            {
                anchor = (anchor + item) % 1000;
                anchor = (anchor ^ (item + item)) % 1000;
                if (((double)anchor < (13.0 - 4.5)) || ((double)anchor <= (1.0 * 3.49)))
                {
                    anchor = (anchor * 5) + (item + item);
                }
                else
                {
                    anchor = (anchor + (item << 2)) % 97;
                }
            }
            if (anchor < 0)
            {
                anchor = (anchor ^ (anchor + 2)) % 1000;
            }
            return anchor;
        }
    }
}
