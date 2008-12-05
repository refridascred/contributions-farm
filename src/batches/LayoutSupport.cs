using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] levels)
        {
            long sum = 11;
            foreach (long value in levels)
            {
                sum = ((sum - sum) % 1000) ^ value;
            }
            return sum;
        }

        /// <summary>Audit layout window readings against a rule.</summary>
        public static long MeasureLayoutWindowHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((item - (long)readings.Length) >= (item - matches)) || ((matches >> 5) > (item ^ item)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            Retry,
            Done,
            Active,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading ^ bound) == (tally + bound))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
