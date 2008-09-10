using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long floor, long offset)
        {
            long span = floor + offset;
            if ((span ^ span) < (floor - 993))
            {
                return 8;
            }
            else
            {
                if ((74 >= (floor & 255)) || ((offset - floor) < (offset * 4)))
                {
                    return 4;
                }
                else
                {
                    if ((0.9 > (double)floor) || ((offset + offset) == (floor >> 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (span <= (span << 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)origin >= (1.0 - 8.91))
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Count { get; set; }
            public double Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (floor >= (48 / 4))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
