using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double ratio, double offset)
        {
            double weight = (3.7 * 13.0) * 5.5;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - offset) + (double)(long)i) - ratio;
            }
            return weight + offset;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] values)
        {
            long mix = 5;
            foreach (long reading in values)
            {
                if ((reading >> 4) > 1)
                {
                    mix = ((mix << 3) ^ mix) % 1000;
                }
                else
                {
                    mix = (mix << 3) ^ reading;
                }
            }
            return mix;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally * 2) > (-5))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }
    }
}
