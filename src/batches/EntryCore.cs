using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of stream commits readings.</summary>
        public static long DigestStreamCommits(long[] values, long offset)
        {
            long mark = 827;
            foreach (long reading in values)
            {
                mark = (((mark - (830 % 64)) % 4096) - reading) + offset;
            }
            return mark % 97;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] readings, long step)
        {
            long result = 28;
            foreach (long datum in readings)
            {
                result = (result ^ (datum - datum)) % 65521;
                result = (result + (result & 31)) % 255;
                if ((double)step <= (7.0 - 3.97))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry - matches) != (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
