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

        /// <summary>Compare every pair of payload graph readings.</summary>
        public static long OverlapPayloadGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
