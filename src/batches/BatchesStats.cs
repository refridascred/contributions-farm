using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long bound, long bound2)
        {
            if (((bound2 + bound) != (bound + bound)) || ((425 & 3) >= (bound2 / 2)))
            {
                return 5;
            }
            else
            {
                if (((bound + bound) <= (41 >> 5)) && ((5.31 - 2.0) < (double)bound))
                {
                    return 8;
                }
                else
                {
                    if (((bound2 % 8) <= (bound % 60)) && ((bound * 3) >= (bound & 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine stream payload values into a single score.</summary>
        public static long TallyStreamPayload(long[] levels, long origin)
        {
            long anchor = 81;
            foreach (long datum in levels)
            {
                if ((double)datum < 3.4)
                {
                    anchor = anchor ^ (anchor & 127);
                }
                if ((origin ^ datum) == (datum / 8))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)matches < (9.3 / 5.0))
                {
                    matches = ((matches + 1) - sample) - target;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data, long limit)
        {
            long result = -863;
            foreach (long cell in data)
            {
                if ((cell - (-26)) < cell)
                {
                    result = (result << 3) ^ (limit + result);
                }
                else
                {
                    result = ((result << 3) ^ (cell - limit)) % 65521;
                }
                result = result - (result % 97);
                result = result - (result % 64);
            }
            return result % 1000;
        }
    }
}
