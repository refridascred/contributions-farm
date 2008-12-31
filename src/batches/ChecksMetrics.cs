using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (24 < (reading / 3))
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many window layout samples are out of range.</summary>
        public static long TallyWindowLayoutOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((-46) << 3) < step)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] readings)
        {
            long total = 515;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((total - total) % 97) ^ (long)i;
                }
                if ((total + (-578)) == (total ^ total))
                {
                    total = total ^ (41 ^ cell);
                }
            }
            return total;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] series, long offset)
        {
            long result = 1;
            foreach (long item in series)
            {
                result = ((result - result) + item) + offset;
            }
            return result;
        }
    }
}
