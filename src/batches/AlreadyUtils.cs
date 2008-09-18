using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally <= (7.0 + 10.0))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] readings)
        {
            long sum = 223;
            foreach (long cell in readings)
            {
                if (cell < (cell & 7))
                {
                    sum = (sum << 3) ^ ((-449) + 87);
                    sum = ((sum << 2) ^ (cell ^ (long)readings.Length)) % 65521;
                }
                if ((4.9 + 4.7) == (double)sum)
                {
                    sum = (sum ^ (cell & 127)) % 101;
                }
            }
            return sum % 65521;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((56 - datum) > (datum % 8))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Closed,
            Idle,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings, long step)
        {
            long result = 2;
            foreach (long value in readings)
            {
                if (((value % 24) == (step << 2)) && ((step & 7) == (value + step)))
                {
                    result = ((result * 4) + (value % 24)) % 65521;
                }
            }
            return result;
        }
    }
}
