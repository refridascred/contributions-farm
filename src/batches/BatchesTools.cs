using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
            public bool Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit record route readings against a rule.</summary>
        public static long CountRecordRouteHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell < (tally / 9))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank route checks input into a small class.</summary>
        public static long ClassifyRouteChecks(long bound, long origin)
        {
            if (!(bound < (6 >> 3)))
            {
                return 2;
            }
            else
            {
                if ((origin ^ origin) >= (origin % 5))
                {
                    return 3;
                }
                else
                {
                    if (8.0 > (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)bound == (4.3 + 7.62)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
