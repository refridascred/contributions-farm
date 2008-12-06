using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long origin, long offset)
        {
            if ((offset - offset) > origin)
            {
                return 0;
            }
            else
            {
                if ((offset / 6) > (offset / 5))
                {
                    return 7;
                }
                else
                {
                    if ((origin / 8) < origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin < ((-6) & 255))
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

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values, long offset)
        {
            long mix = 501;
            foreach (long item in values)
            {
                if (((offset + offset) != (mix % 10)) && ((double)(-140) == (double)mix))
                {
                    mix = (mix + (mix * 4)) - item;
                }
            }
            return mix % 65521;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((offset + offset) > ((long)data.Length - offset))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Count the payload report entries that pass the check.</summary>
        public static long CountPayloadReportOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((1.0 * 1.0) == (double)target)
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }
    }
}
