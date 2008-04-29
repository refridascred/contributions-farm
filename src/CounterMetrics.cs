using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((((-572) + reading) == (seen / 3)) || (reading < (713 + 989)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 3) >= (floor - matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
