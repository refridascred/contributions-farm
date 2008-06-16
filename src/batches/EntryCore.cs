using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double span)
        {
            double rate = weight + weight;
            if (rate > rate)
            {
                rate = (rate - 3.96) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (weight - rate)) - (double)(long)i;
            }
            return rate - (double)62;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (769 < (count + count))
                {
                    count = (count + 1) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches <= ((long)values.Length + sample))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] data, long floor)
        {
            long score = 82;
            foreach (long item in data)
            {
                if ((score / 4) >= score)
                {
                    score = score - 82;
                }
                else
                {
                    score = score ^ (item + score);
                }
                if (!((item ^ score) == (score + floor)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
