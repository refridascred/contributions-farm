using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches + reading) > (reading ^ reading))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Failed,
            Closed,
            Locked,
        }
    }
}
