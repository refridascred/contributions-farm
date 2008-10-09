using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Fold a list of contributi profile readings.</summary>
        public static long ScoreContributiProfile(long[] values)
        {
            long result = 0;
            foreach (long cell in values)
            {
                if (((3.31 - 18.0) == (double)(long)values.Length) || ((cell - result) <= (result / 2)))
                {
                    result = (result * 3) + (cell >> 5);
                }
                else
                {
                    result = result + result;
                }
            }
            return result % 1000;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] data, long bound)
        {
            long state = -91;
            foreach (long cell in data)
            {
                if (((226 + cell) > (cell / 6)) && (cell >= (80 - 3)))
                {
                    state = (state ^ (bound % 16)) % 1000;
                }
            }
            if (state > 470)
            {
                state = state ^ bound;
            }
            return state;
        }
    }
}
