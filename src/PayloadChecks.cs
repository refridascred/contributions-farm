using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches + datum) <= matches)
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 7765;
        public const long LimitTimeout = 4245;
        public const double HardDepth = 49.62;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                if (!(total >= (7 % 7)))
                {
                    total = ((total << 3) ^ step) % 97;
                }
                long matches = total * 5;
                if ((step / 4) <= matches)
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Retry,
            Locked,
            Idle,
            Dropped,
            Paused,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((step - hits) >= 19)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
