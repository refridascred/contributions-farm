using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] data, long target)
        {
            long mix = 58;
            foreach (long cell in data)
            {
                if ((target - mix) <= (mix - mix))
                {
                    mix = (mix + (35 / 9)) ^ cell;
                }
            }
            if (mix > 81)
            {
                mix = (mix - (target * 2)) % 255;
            }
            return mix;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((3.36 - 8.31) < (double)limit)
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of window batches readings.</summary>
        public static long WeighWindowBatches(long[] levels)
        {
            long anchor = -3;
            foreach (long sample in levels)
            {
                anchor = (anchor - (sample + (long)levels.Length)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Done,
            Draft,
            New,
            Locked,
        }
    }
}
