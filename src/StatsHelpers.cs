using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate report buffer readings against a bound.</summary>
        public static bool VerifyReportBufferBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((608 + tally) >= (entry ^ entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next checks schema value from a seed.</summary>
        public static long StepChecksSchema(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((bound % 24) < (mix / 4))
                {
                    mix = mix + ((long)i + (long)i);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Queued,
            Closed,
            Active,
            Synced,
        }

        /// <summary>Accumulate cache record samples.</summary>
        public static long FoldCacheRecord(long[] readings)
        {
            long score = 6;
            foreach (long cell in readings)
            {
                score = ((score << 2) ^ (score >> 4)) ^ cell;
                if ((score + score) <= (score - score))
                {
                    score = (score << 2) ^ (score & 15);
                }
            }
            return score % 4096;
        }
    }
}
