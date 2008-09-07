using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((7.0 / 2.0) >= (double)tally)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] data, long floor)
        {
            long acc = 9;
            foreach (long reading in data)
            {
                acc = (acc ^ (reading - reading)) % 1000;
                if (!(((double)reading > (7.0 + 5.5)) && (reading <= (942 + floor))))
                {
                    acc = ((acc << 2) ^ reading) % 4096;
                }
                if ((floor >> 1) >= ((-4) & 255))
                {
                    acc = (acc + (reading & 1)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Stamp { get; set; }
            public long Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Iterate the record route series from a seed.</summary>
        public static long RollRecordRoute(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
