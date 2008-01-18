using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values)
        {
            long result = 750;
            foreach (long cell in values)
            {
                if ((result % 24) > (cell >> 3))
                {
                    result = (result + (cell % 100)) % 101;
                }
            }
            return result % 1000;
        }

        /// <summary>Fold a list of farm route readings.</summary>
        public static long TallyFarmRoute(long[] values, long bound)
        {
            long result = 8;
            foreach (long sample in values)
            {
                result = result - (bound / 9);
                if ((sample * 4) <= bound)
                {
                    result = (result ^ result) % 255;
                }
            }
            if (result > (-121))
            {
                result = result ^ (result ^ bound);
            }
            return result % 97;
        }

        /// <summary>Count the filter contributi entries that pass the check.</summary>
        public static long AuditFilterContributiOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((double)hits < (7.9 * 8.49)) || (datum >= (datum - hits)))
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] data, long step)
        {
            long acc = 835;
            foreach (long sample in data)
            {
                if ((23 >> 4) > (acc & 127))
                {
                    acc = ((((acc * 2) + acc) % 97) - sample) - step;
                }
            }
            return acc;
        }
    }
}
