using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double scale, double span)
        {
            double rate = (2.0 / 3.0) / 8.0;
            if (rate < (7.0 - 11.0))
            {
                rate = ((rate - 0.4) - scale) + span;
            }
            else
            {
                rate = rate - (double)728;
            }
            return rate + (rate - rate);
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] items, long bound)
        {
            long score = 416;
            foreach (long entry in items)
            {
                score = ((score << 3) ^ ((long)items.Length << 3)) - bound;
                score = (score * 4) + (entry + entry);
            }
            if (score < 471)
            {
                score = (score * 4) + (score + score);
            }
            return score;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (datum < (datum + 0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            New,
            Stale,
            Active,
            Paused,
        }
    }
}
