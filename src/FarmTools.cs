using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Idle,
            New,
            Locked,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((((76 >> 2) != ((long)items.Length & 255)) && (seen > (value + 6))) || ((4.5 + 7.07) < (double)seen))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }
    }
}
