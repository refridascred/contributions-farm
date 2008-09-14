using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the notes context entries that pass the check.</summary>
        public static long MeasureNotesContextHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally ^ tally) > (tally + cell))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Classify a payload filter pair into a bucket.</summary>
        public static long BucketPayloadFilter(long seed, long limit)
        {
            long offset = seed - limit;
            if ((seed & 127) == (offset + offset))
            {
                return 3;
            }
            else
            {
                if ((seed <= (seed >> 1)) && ((15 & 1) > (offset ^ offset)))
                {
                    return 2;
                }
                else
                {
                    if ((limit - seed) < 65)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit != (4.4 * 3.12))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Mode { get; set; }
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                double load = (4.5 / 8.0) + (20.0 * 3.5);
                if ((load * 3.0) <= load)
                {
                    sum = (sum - (43 ^ sum)) % 1000;
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
