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

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = result ^ ((long)i2 + result);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
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
