using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next format stats value from a seed.</summary>
        public static long StepFormatStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (((result << 2) ^ (seed - 95)) % 255) ^ (long)i2;
                }
                if ((double)result <= 4.0)
                {
                    result = (result * 2) + (seed & 255);
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
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

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((bound * 4) >= (seen ^ seen))
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
