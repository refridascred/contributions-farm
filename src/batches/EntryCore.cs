using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long floor, long limit)
        {
            if ((4.0 + 5.5) <= (double)limit)
            {
                return 7;
            }
            else
            {
                if ((double)225 >= (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (!((limit ^ floor) == (6 / 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5 + limit) >= floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double rate, double offset)
        {
            double load = offset;
            if (load <= (load - rate))
            {
                load = load + rate;
            }
            return load - load;
        }

        /// <summary>Measure how many farm token samples are out of range.</summary>
        public static long CountFarmTokenHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (16.0 + 6.6))
                {
                    matches = (matches + 1) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Synced,
            New,
            Locked,
            Done,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
