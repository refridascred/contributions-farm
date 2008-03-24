using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double rate, double offset)
        {
            double drift = (offset * 2.0) * 5.51;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - (2.6 - offset)) + (double)(long)i) - rate;
            }
            return drift + (offset * 17.0);
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (datum >= (datum << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] samples)
        {
            long acc = 0;
            foreach (long reading in samples)
            {
                if ((acc << 3) <= (reading * 2))
                {
                    acc = (acc ^ (acc << 1)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark << 2) ^ 0) % 97;
                if ((double)(long)i == (4.0 - 17.0))
                {
                    mark = mark ^ mark;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((((0.9 / 4.0) > (double)item) && ((double)hits > (2.8 + 6.0))) && ((hits > (floor ^ 66)) || ((1.4 / 5.0) <= 8.5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Closed,
            Active,
            Pending,
            Paused,
        }
    }
}
