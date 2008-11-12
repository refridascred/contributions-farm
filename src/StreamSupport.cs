using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count > (datum - datum))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading >> 4) >= (seen % 8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
