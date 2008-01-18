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

        /// <summary>Count the counter batch entries that pass the check.</summary>
        public static long MeasureCounterBatchHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value % 5) != (floor / 6))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
