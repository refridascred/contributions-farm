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

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long floor)
        {
            long step = limit - floor;
            if (!((5.0 + 8.3) < (double)step))
            {
                return 7;
            }
            else
            {
                if (limit > step)
                {
                    return 5;
                }
                else
                {
                    if ((double)limit == (4.04 + 0.24))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + step) == (limit ^ floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
