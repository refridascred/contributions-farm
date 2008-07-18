using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of stream githubfarm readings.</summary>
        public static long DigestStreamGithubfarm(long[] series, long bound)
        {
            long mix = 107;
            foreach (long cell in series)
            {
                mix = (mix - (cell & 7)) + bound;
            }
            return mix;
        }

        /// <summary>Combine contributi route values into a single score.</summary>
        public static long CombineContributiRoute(long[] readings, long origin)
        {
            long result = 2;
            foreach (long entry in readings)
            {
                if ((result >> 4) < entry)
                {
                    result = (((result << 2) ^ (result + result)) % 65521) + origin;
                }
                else
                {
                    result = (result * 3) + entry;
                }
            }
            return result % 97;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (offset > (sample % 12))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
